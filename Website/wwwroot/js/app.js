const flags = document.querySelectorAll("[data-flag]"); // An array of all Flags / Images
const translations = JSON.parse(document.currentScript.getAttribute('translation_text')); // The translation text as JSON
const planetObjects = JSON.parse(document.currentScript.getAttribute('planets_text')); // All planets & their information as JSON
const planets = document.querySelectorAll("[data-click]"); // An array of all Planets
const modal = document.getElementById("information-modal"); // A modal, for displaying information about the planets
const modal_close_btn = document.getElementById("information-modal-close-btn"); // The closing button 'x' for the modal
const start_btn = document.querySelector(".start-btn"); // The button to start the game
const game_question = document.querySelector("#game-question"); // The question element
const game_answer_grid = document.querySelector(".answer-grid"); // The answer grid element
let game_state = false; // false == not running, true == running
let onGoing = false; // true == busy
let game_question_index = 0; // The index for the questions
let lang; // The language code
let ws; // A WebSocket instance
try {
    ws = new WebSocket("ws://192.168.1.122:8008");
} catch (e) { }

planetObjects.forEach(planetObj => {
    planetObj.Info_as_json = JSON.parse(planetObj.Info_as_json);
});

// Find the language from the browser default.
switch (navigator.language) {
    case 'da':
    case 'da-DK':
        lang = "da";
        break;
    case 'en':
    case 'en-US':
    case 'en-GB':
        lang = "en";
        break;
    case 'hu':
        lang = "hu";
        break;
    default:
        lang = "en";
        break;
}

// Run it on load
updateLanguage(lang);

// On load, run this to select the default language flag & highlight it
flags.forEach(flag => {
    if (lang == flag.getAttribute("data-flag")) {
        flag.classList.add("selected");
    }

    flag.addEventListener("click", () => {
        setLanguage(flag);
    });
});

// Add an eventlistener of click to all planets
planets.forEach(planet => {
    planet.addEventListener("click", () => {
        if (!game_state) {


            let planetIndex = planet.getAttribute("data-index");

            let index = 0;
            for (let i = 0; i < planetObjects.length; i++) {
                if (planetObjects[i].Id == planetIndex && planetObjects[i].Lang == lang) {
                    index = i;
                    i = planetObjects.length;
                }
            }
            planetIndex = index;

            let factIndex = 0;
            let maxIndex = planetObjects[planetIndex].Info_as_json.Statements.length - 1;

            document.querySelector("body").style.overflowY = "hidden"; // Disable scroll on the body
            modal.classList.add("open");

            // Update the modal content
            const modalHeader = modal.querySelector(".header h3");

            modalHeader.querySelector(".icon").src = planet.src;
            modalHeader.querySelector("span").innerText = planetObjects[planetIndex].Info_as_json.Name;

            const modalContent = modal.querySelector(".content>p.fact");
            const prevFact = modal.querySelector(".content .prev-btn");
            const nextFact = modal.querySelector(".content .next-btn");

            prevFact.addEventListener("click", () => {
                factIndex = factIndex > 0 ? factIndex - 1 : 0;
                modalContent.innerHTML = `${factIndex + 1}: ${planetObjects[planetIndex].Info_as_json.Statements[factIndex]}`;
            });

            nextFact.addEventListener("click", () => {
                factIndex = factIndex < maxIndex ? factIndex + 1 : maxIndex;
                modalContent.innerHTML = `${factIndex + 1}: ${planetObjects[planetIndex].Info_as_json.Statements[factIndex]}`;
            });

            modalContent.innerHTML = `${factIndex + 1}: ${planetObjects[planetIndex].Info_as_json.Statements[factIndex]}`; // Set the fact to the first one
        }
    });
});

// Add closing action to the information modal
modal_close_btn.addEventListener("click", () => {
    modal.classList.add("closing");

    document.querySelector("body").style.overflowY = "auto"; // Enable scrolling on the body again

    modal.addEventListener("animationend", animationEnd);
});

// Start the game
start_btn.addEventListener("click", () => {
    start_btn.classList.add("hidden");
    game_answer_grid.classList.remove("hidden");

    game_state = true;

    game_question.querySelector("h3").innerText = "Click on a planet to conquer it";
    game_question.querySelector("h3").removeAttribute("data-translation");

    // Add new event listeners to all planets
    planets.forEach(planet => {
        planet.classList.add("inactive");
        planet.title = "You haven't unlocked this planet yet";

        planet.addEventListener("click", () => {
            if (!onGoing && planet.classList.contains("inactive")) {
                planet.classList.remove("inactive");
                planet.classList.add("active");
                planet.title = `${planet.alt}`;

                takeQuiz(planet);
            } else {
                try {
                    ws.send(planet.getAttribute("data-click"));
                } catch (e) {
                    console.log(e);
                }
            }
        });
    });

    //// Initiate all buttons / answers
    //for (child of game_answer_grid.children) {
    //    const c = child;

    //    child.addEventListener("click", () => {
    //        game_answer_grid.innerHTML = "";

    //        planets.forEach(planet => {
    //            if (planet.getAttribute("data-index") == c.getAttribute("data-index")) {
    //                planet.classList.remove("inactive");
    //                planet.classList.add("active");
    //                planet.title = `${planet.alt}`;

    //                takeQuiz(planet);
    //            }
    //        });
    //    });
    //}
});

function takeQuiz(planet) {
    try {
        ws.send(planet.getAttribute("data-click")); // Move the ufo to
    } catch (e) {
        console.log(e);
    }

    let planetIndex;
    let questionIndex = 0;
    let maxIndex;
    let score = 0;

    planetIndex = planet.getAttribute("data-index");

    let index = 0;
    for (let i = 0; i < planetObjects.length; i++) {
        if (planetObjects[i].Id == planetIndex && planetObjects[i].Lang == lang) {
            index = i;
            i = planetObjects.length;
        }
    }
    planetIndex = index;

    maxIndex = planetObjects[planetIndex].Info_as_json.Quests.length - 1;



    const timer = setInterval(() => {
        if (!onGoing) {
            onGoing = true;
            showQuestion(planetIndex, questionIndex).then((r) => {
                onGoing = false;
                questionIndex = questionIndex < maxIndex ? ++questionIndex : maxIndex;
                //game_question.querySelector("h3.score").innerText = ++score;
                score++;

                if (score >= 3) {
                    clearInterval(timer);
                    clearAnswers();
                    planet.className = "";
                    ws.send(planet.getAttribute("data-lock"));

                    let didIWin = true;
                    planets.forEach(planet => {
                        if (planet.classList.contains("inactive")) {
                            didIWin = false;
                        }
                    });

                    if (didIWin) {
                        setTimeout(() => {
                            alert(`Congratulations, you conquered the entire solar system!`);
                        }, 50);
                    } else {
                        setTimeout(() => {
                            alert(`Congratulations, you conquered ${planet.title}!`);
                        }, 50);
                    }
                }
                //console.log(r);
            }).catch((e) => {
                onGoing = false;
                questionIndex = questionIndex < maxIndex ? ++questionIndex : maxIndex;

                if (questionIndex >= maxIndex) {
                    clearInterval(timer);
                    clearAnswers();
                    planet.className = "destroyed";
                }


                //console.log(e);
            });
        }
    }, 50);



    /* while (score < 3) */
    //if (showQuestion(planetIndex, questionIndex)) {
    //    score++;
    //}

    //questionIndex = questionIndex < maxIndex ? questionIndex++ : maxIndex;
    //game_question.querySelector("h3.score").innerText = score;
}

function showQuestion(planetIndex, questionIndex) {
    return new Promise((resolve, reject) => {
        game_answer_grid.innerHTML = "";
        game_question.querySelector("h3").innerHTML = planetObjects[planetIndex].Info_as_json.Quests[questionIndex].Question;

        // Create answers
        let tempIndex = 0;
        planetObjects[planetIndex].Info_as_json.Quests[questionIndex].Answers.forEach(ans => {
            let answer = document.createElement("button");

            answer.setAttribute("data-index", `${tempIndex++}`);
            answer.className = "overflow-dots";
            answer.type = "button";
            answer.innerText = ans;

            answer.addEventListener("click", () => {
                const a = answer;

                if (a.getAttribute("data-index") == planetObjects[planetIndex].Info_as_json.Quests[questionIndex].CorrectAnswerIndex) {
                    answer.classList.add("right");
                    setTimeout(() => {
                        resolve(true);
                    }, 500);
                } else {
                    answer.classList.add("wrong");
                    setTimeout(() => {
                        reject(false);
                    }, 500);
                }
            });

            game_answer_grid.appendChild(answer);
        });
    });
}

function clearAnswers() {
    return new Promise((resolve, reject) => {
        game_answer_grid.innerHTML = "";
        game_question.querySelector("h3").innerHTML = "Click a new planet to conquer it";

        resolve();
    });
}

// When the animation ends, remove the classes & eventlistener
function animationEnd() {
    modal.classList.remove("open");
    modal.classList.remove("closing");

    modal.removeEventListener("animationend", animationEnd);
}

// A function to update the HTML with a new language, in case it was changed
function updateLanguage() {
    const textToTranslate = document.querySelectorAll("[data-translation]"); // An array of all HTML elements to translate

    textToTranslate.forEach(el => {
        switch (lang) {
            case 'da':
                try {
                    el.innerHTML = `${translations[el.getAttribute("data-translation") - 1].Da}`;
                } catch (e) {
                    el.innerText = `Dansk`;
                }
                break;
            case 'en':
                try {
                    el.innerHTML = `${translations[el.getAttribute("data-translation") - 1].En}`;
                } catch (e) {
                    el.innerText = `English`;
                }
                break;
            case 'hu':
                try {
                    el.innerHTML = `${translations[el.getAttribute("data-translation") - 1].Hu}`;
                } catch (e) {
                    el.innerText = `Magyar`;
                }
                break;
            default:
                try {
                    el.innerHTML = `${translations[el.getAttribute("data-translation") - 1].En}`;
                } catch (e) {
                    el.innerText = `English`;
                }
                break;
        }
    });
}

// A helper function to set the language, highlight the selected flag & update the HTML text
function setLanguage(el) {
    lang = el.getAttribute("data-flag");
    updateLanguage();

    flags.forEach(flag => {
        flag.classList.remove("selected");
    });

    el.classList.add("selected");
}
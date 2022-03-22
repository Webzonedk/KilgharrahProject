#include <Stepper.h>

// Pin connections Stepper motor & driver
const short IN1Pin = 2;
const short IN2Pin = 3;
const short IN3Pin = 4;
const short IN4Pin = 5;

// AMount of steps for each revolution in the steppermotor, actually is calculated of steps per round X gear reduction as seen below
// const short stepsPerRound = 32;
// const short gearReduction = 64;
const short stepsPerRevolution = 2048;

// Max 15 RPM @ 5V
const short motorSpeed = 15;

// Create stepper object called 'stepper', note the pin order:
const Stepper stepper = Stepper(stepsPerRevolution, 2, 4, 3, 5);

// Delay to be used in LED functions
const short ledDelay = 100;

// Assigning the ufo leds to pins in array
const short UfoLeds[] = {
    // // Arduino Uno
    // 6,
    // 9,
    // 10,
    // 11
    // Arduino Mega
    8, // Upper right
    11, // Lower right
    10, // Lower Left
    9 // Upper Left
};

// Assigning Planet leds to pins in array
const short PlanetLeds[] = {
    // // For Arduino UNO
    // A0, // Mercury
    // A1, // Venus
    // A2, // Earth
    // A3, // Mars
    // A4, // Jupiter
    // A5, // Saturn
    // 7,  // Uranus
    // 8,  // Neptune
    // 12  // Pluto

    // For Arduino Mega
    A4, // Mercury
    A5, // Venus
    A6, // Earth
    A7, // Mars
    A8, // Jupiter
    A9, // Saturn
    A10, // Uranus
    A11, // Neptune
    A12 // Pluto
};

bool PlanetLock[] = {
    false, // Mercury
    false, // Venus
    false, // Earth
    false, // Mars
    false, // Jupiter
    false, // Saturn
    false, // Uranus
    false, // Neptune
    false // Pluto
};

const int PlanetPositions[] = {
    0, // Mercury
    1412, // Venus
    2499, // Earth
    3531, // Mars
    6302, // Jupiter
    10648, // Saturn
    21295, // Uranus
    27325, // Neptune
    32378 // Pluto
};

// Starting position, to be used for calculating the current position
int CurrentPosition = 0;

// It takes 1.953125ms per step on the motor
const double msPerStep = 1.953125;

// Proberty to keep the input chars from serial
char input;

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Just the setup
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void setup() {
    // Setting baudrate
    Serial.begin(9600);

    // Set all planets as output
    for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++) {
        pinMode(PlanetLeds[i], OUTPUT);
    }

    // Set all UFO Leds as output
    for (int i = 0; i < sizeof(UfoLeds) / sizeof(short); i++) {
        pinMode(UfoLeds[i], OUTPUT);
    }
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Main loop, controlling the UFO movements, blinking and planets light on & off
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void loop() {
    while (Serial.available() > 0) {
        input = Serial.read();

        switch (input) {
        case '0': // Mercury
            turnOffPlanets();
            moveAndBlink(PlanetPositions[0] - CurrentPosition);
            turnOnPlanet(PlanetLeds[0]);
            break;
        case 'q': // Mercury unlocked
            PlanetLock[0] = true;
            //Serial.println("Locked planet 0"); // DEBUG
            break;
        case '1': // Venus
            turnOffPlanets();
            moveAndBlink(PlanetPositions[1] - CurrentPosition);
            turnOnPlanet(PlanetLeds[1]);
            break;
        case 'w': // Venus unlocked
            PlanetLock[1] = true;
            //Serial.println("Locked planet 1"); // DEBUG
            break;
        case '2': // Earth
            turnOffPlanets();
            moveAndBlink(PlanetPositions[2] - CurrentPosition);
            turnOnPlanet(PlanetLeds[2]);
            break;
        case 'e': // Earth unlocked
            PlanetLock[2] = true;
            //Serial.println("Locked planet 2"); // DEBUG
            break;
        case '3': // Mars
            turnOffPlanets();
            moveAndBlink(PlanetPositions[3] - CurrentPosition);
            turnOnPlanet(PlanetLeds[3]);
            break;
        case 'r': // Mars unlocked
            PlanetLock[3] = true;
            //Serial.println("Locked planet 3"); // DEBUG
            break;
        case '4': // Jupiter
            turnOffPlanets();
            moveAndBlink(PlanetPositions[4] - CurrentPosition);
            turnOnPlanet(PlanetLeds[4]);
            break;
        case 't': // Jupiter unlocked
            PlanetLock[4] = true;
            //Serial.println("Locked planet 4"); // DEBUG
            break;
        case '5': // Saturn
            turnOffPlanets();
            moveAndBlink(PlanetPositions[5] - CurrentPosition);
            turnOnPlanet(PlanetLeds[5]);
            break;
        case 'y': // Saturn unlocked
            PlanetLock[5] = true;
            //Serial.println("Locked planet 5"); // DEBUG
            break;
        case '6': // Uranus
            turnOffPlanets();
            moveAndBlink(PlanetPositions[6] - CurrentPosition);
            turnOnPlanet(PlanetLeds[6]);
            break;
        case 'u': // Uranus unlocked
            PlanetLock[6] = true;
            //Serial.println("Locked planet 6"); // DEBUG
            break;
        case '7': // Neptune
            turnOffPlanets();
            moveAndBlink(PlanetPositions[7] - CurrentPosition);
            turnOnPlanet(PlanetLeds[7]);
            break;
        case 'i': // Neptune unlocked
            PlanetLock[7] = true;
            //Serial.println("Locked planet 7"); // DEBUG
            break;
        case '8': // Pluto
            turnOffPlanets();
            moveAndBlink(PlanetPositions[8] - CurrentPosition);
            turnOnPlanet(PlanetLeds[8]);
            break;
        case 'o': // Pluto unlocked
            PlanetLock[8] = true;
            //Serial.println("Locked planet 8"); // DEBUG
            break;
            //-------------------------------------------------
            // To simulate planets turning on, on Arduino Uno
        case 'a':
            turnOnPlanet(PlanetLeds[0]);
            break;
        case 's':
            turnOnPlanet(PlanetLeds[1]);
            break;
        case 'd':
            turnOnPlanet(PlanetLeds[2]);
            break;
        case 'f':
            turnOnPlanet(PlanetLeds[3]);
            break;
        case 'g':
            turnOnPlanet(PlanetLeds[4]);
            break;
        case 'h':
            turnOnPlanet(PlanetLeds[5]);
            break;
        case 'j':
            turnOnPlanet(PlanetLeds[6]);
            break;
        case 'k':
            turnOnPlanet(PlanetLeds[7]);
            break;
        case 'l':
            turnOnPlanet(PlanetLeds[8]);
            break;
        case 'z':
            turnOffPlanets();
            break;
        case 'x':
            winnerBlink(5);
            break;
        default:
            break;
        }
    }

    //-------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------
    // UFO Pulsing when idle
    //-------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------
    // Fade in
    for (int i = 0; i <= 255; i += 5) {
        for (int j = 0; j < 4; j++) {
            analogWrite(UfoLeds[j], i);
            delay(7);
        }
    }

    // Fade out
    for (int i = 255; i >= 0; i -= 5) {
        for (int j = 0; j < 4; j++) {
            analogWrite(UfoLeds[j], i);
            delay(7);
        }
    }
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Blinks the ufo 5 times, and moving to the planet connected with the incomming string
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void moveAndBlink(int stepsToTake) {
    int stepsPerRound = round(ledDelay / msPerStep);
    int stepsRemaining = stepsToTake;
    int negativeStepsPerRound = stepsPerRound * -1;

    blinkUfo(5); // Blink UFO Led's
    turnOnMotor(); // Turn on the motor / Start the engine

    while (stepsRemaining != 0) {
        // Serial.print("stepsToTake: ");    // DEBUG
        // Serial.println(stepsToTake);      // DEBUG
        // Serial.print("stepsRemaining: "); // DEBUG
        // Serial.println(stepsRemaining);   // DEBUG

        // Moving forward if stepsToTake is a positive number
        if (stepsRemaining > 0) {
            // Serial.print("stepsPerRound: "); // DEBUG
            // Serial.println(stepsPerRound);   // DEBUG
            for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++) {
                if (stepsRemaining >= stepsPerRound) {
                    analogWrite(UfoLeds[j], 255);
                    stepper.step(stepsPerRound);
                    analogWrite(UfoLeds[j], 0);

                    stepsRemaining -= stepsPerRound;
                } else if (stepsRemaining < stepsPerRound) {
                    analogWrite(UfoLeds[j], 255);
                    stepper.step(stepsRemaining);
                    analogWrite(UfoLeds[j], 0);

                    stepsRemaining -= stepsRemaining;
                }
                // Serial.print("stepsRemaining: "); // DEBUG
                // Serial.println(stepsRemaining);   // DEBUG
            }
        }

        // Moving backwards if stepsToTake is negative
        if (stepsRemaining < 0) {
            // Serial.print("negativeStepsPerRound: "); // DEBUG
            // Serial.println(negativeStepsPerRound);   // DEBUG
            for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++) {
                if (stepsRemaining <= negativeStepsPerRound) {
                    analogWrite(UfoLeds[j], 255);
                    stepper.step(negativeStepsPerRound);
                    analogWrite(UfoLeds[j], 0);

                    stepsRemaining += stepsPerRound;
                } else if (stepsRemaining > negativeStepsPerRound) {
                    analogWrite(UfoLeds[j], 255);
                    stepper.step(stepsRemaining);
                    analogWrite(UfoLeds[j], 0);

                    stepsRemaining += stepsRemaining * -1;
                }
                // Serial.print("stepsRemaining: "); // DEBUG
                // Serial.println(stepsRemaining);   // DEBUG
            }
        }
    }

    CurrentPosition += stepsToTake;

    turnOffMotor(); // Turn off the motor / Stop the engine
    blinkUfo(5); // Blink UFO Led's

    //Serial.print("CurrentPosition: "); // DEBUG
    //Serial.println(CurrentPosition); // DEBUG
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Blink the UFO Leds in a circular motion twice
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void blinkUfo(int iterations) {
    for (int i = 0; i < iterations; i++) {
        for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++) {
            analogWrite(UfoLeds[j], 255);
            delay(ledDelay);
            analogWrite(UfoLeds[j], 0);
        }
    }
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Function to turn on the light inside the planet, when the UFO arrives
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void turnOnPlanet(short planetPin) {
    Serial.print("Turned on planet: "); // DEBUG
    Serial.println(planetPin);
    // if (planetPin <= 13)
    // {
    digitalWrite(planetPin, HIGH);
    // Serial.print("Turned on "); //DEBUG
    // Serial.print(planetPin); //DEBUG
    // Serial.println(" digital"); //DEBUG
    // }
    // else
    // {
    //   analogWrite(planetPin, 255);
    //   // Serial.print("Turned on "); //DEBUG
    //   // Serial.print(planetPin); //DEBUG
    //   // Serial.println(" analog"); //DEBUG
    // }
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Function to turn off the light in the planet, when the UFO leaves the planet.
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void turnOffPlanets() {
    //Serial.println("Turning off planets"); // DEBUG

    for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++) {
        if (PlanetLock[i] == false) {
            // if (PlanetLeds[i] <= 13)
            // {
            digitalWrite(PlanetLeds[i], LOW);
            Serial.print("Turned off ");
            Serial.print(PlanetLeds[i]);
            Serial.println(" digital");
            // }
            // else
            // {
            //   analogWrite(PlanetLeds[i], 0);
            //   Serial.print("Turned off ");
            //   Serial.print(PlanetLeds[i]);
            //   Serial.println(" analog");
            // }
            // digitalWrite(PlanetLeds[i], LOW);
        }
    }

    //Serial.println("Turned off planets"); // DEBUG
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Function to turn off the light in all planets.
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void turnOffAllPlanets() {
    //Serial.println("Turning off all planets"); // DEBUG

    for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++) {
        PlanetLock[i] = false;
    }

    turnOffPlanets();

    //Serial.println("Turned off all planets"); // DEBUG
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Winner blink making the light run from end to end of the planets.
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
void winnerBlink(int iterations) {
    //Running blink from one end to other
    for (int i = 0; i < iterations; i++) {

        for (int j = 0; j < sizeof(PlanetLeds) / sizeof(short); j++) {
            // if (PlanetLeds[j] <= 13)
            // {
            digitalWrite(PlanetLeds[j], HIGH);
            blinkDelay(ledDelay);
            digitalWrite(PlanetLeds[j], LOW);
            // }
            // else
            // {
            //   analogWrite(PlanetLeds[j], 255);
            //   blinkDelay(j);
            //   analogWrite(PlanetLeds[j], 0);
            // }
        }
        for (int j = sizeof(PlanetLeds) / sizeof(short) - 1; j >= 0; j--) {
            // if (PlanetLeds[j] <= 13)
            // {
            digitalWrite(PlanetLeds[j], HIGH);
            blinkDelay(ledDelay);
            digitalWrite(PlanetLeds[j], LOW);
            // }
            // else
            // {
            //   analogWrite(PlanetLeds[j], 255);
            //   blinkDelay(j);
            //   analogWrite(PlanetLeds[j], 0);
            // }
        }
    }
    //Blinking all planets x times
    for (int i = 0; i < iterations; i++) {
        for (int j = 0; j < sizeof(PlanetLeds) / sizeof(short) - 1; j++) {
            digitalWrite(PlanetLeds[j], HIGH);
        }
        blinkDelay(ledDelay);
        for (int j = 0; j < sizeof(PlanetLeds) / sizeof(short) - 1; j++) {
            digitalWrite(PlanetLeds[j], LOW);
        }
        blinkDelay(ledDelay);
    }
}

// Adjusting the blink delay if the pin is the first or the last. This is used ith the winnerBlink function
void blinkDelay(int j) {
    if (j == 0 || j == sizeof(PlanetLeds) / sizeof(short) - 1) {
        delay(ledDelay / 2);
    } else {
        delay(ledDelay);
    }
}

//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Motor controls
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
// Turn on the motor befor moving
void turnOnMotor() {
    //Serial.println("Turned on motor"); // DEBUG
    stepper.setSpeed(motorSpeed);
}

// Turn off the motor cutting the power to avoid overheating
void turnOffMotor() {
    digitalWrite(IN1Pin, LOW);
    digitalWrite(IN2Pin, LOW);
    digitalWrite(IN3Pin, LOW);
    digitalWrite(IN4Pin, LOW);
    //Serial.println("Turned off motor"); // DEBUG
}

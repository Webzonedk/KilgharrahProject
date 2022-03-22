-- Planets table will hold all numeric/boolean information for a planet, aswell as a foreign key for the TranslatedPlanets table
CREATE TABLE Planets(
	id SERIAL NOT NULL UNIQUE PRIMARY KEY,
	info_as_json TEXT NOT NULL
	--translation_id INT NOT NULL UNIQUE,
	--distance_from_sun BIGINT NOT NULL,
	--diameter INT NOT NULL,
	--rotation_period INT NOT NULL,
	--rotation_speed DOUBLE PRECISION NOT NULL,
	--orbital_period INT NOT NULL,
	--moons TINYINT NOT NULL,
	--mass DECIMAL(53) NOT NULL,
	--highest_temp INT NOT NULL,
	--lowest_temp INT NOT NULL
);

---- TranslatedPlanets holds all translations for a planet
--CREATE TABLE TranslatedPlanets(
--	id SERIAL NOT NULL UNIQUE,
--	lang VARCHAR(2) NOT NULL,
--	name VARCHAR(50) NOT NULL,
--	description_json TEXT NOT NULL,
--	PRIMARY KEY(id, lang)
--);

-- TranslationText holds general text translations
CREATE TABLE TranslationText(
	id SERIAL NOT NULL UNIQUE PRIMARY KEY,
	da TEXT NOT NULL,
	en TEXT NOT NULL,
	hu TEXT NOT NULL
);
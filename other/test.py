from imdb import Cinemagoer
import wget
import json

import utils

ia = Cinemagoer()

# Checking starting ids for each table
#with open("./starting_ids.json", "r") as json_file:
    #ids = json.load(json_file)
    #print(ids)
#ids['movie_id'] += 1
#with open("./starting_ids.json", "w") as json_file:
    #json.dump(ids, json_file, indent=4)

#movie = ia.search_movie("The Lord of the Rings The Return of the King")
#movie = ia.get_movie("0091251")

#wget.download(movie['full-size cover url'], f"./The Lord of the Rings The Two Towers.jpg")
#print(movie['director'])

person_insert_statement = "INSERT INTO Persons (person_id, imdb_id, name) VALUES(0, '0001104', 'Frank Darabont');"
company_insert_statement = "INSERT INTO Companies (company_id, imdb_id, name) VALUES(10, '0002663', 'Warner Bros.');"
genre_insert_statement = "INSERT INTO genres (genre_id, name) VALUES(19, 'Film-Noir');"
language_insert_statement = "INSERT INTO Languages (language_id, language_code, name) VALUES(30, 'yi', 'Yiddish');"
country_insert_statement = "INSERT INTO Countries (country_id, country_code, name) VALUES(4, 'es', 'Spain');"

# Text slugification test
assert utils.slugify("-Avengers é@$()\/|`'\" Endgame-_") == "Avengers_e_Endgame"
print("- text slugification test passed")

# Person insert statement data retrieval tests
assert utils.get_person_id(person_insert_statement) == "0"
print("- get person id test passed")
assert utils.get_person_imdb_id(person_insert_statement) == "0001104"
print("- get person imdb_id test passed")
assert utils.get_person_name(person_insert_statement) == "Frank Darabont"
print("- get person name test passed")

# Company insert statement data retrieval tests
assert utils.get_company_id(company_insert_statement) == "10"
print("- get company id test passed")
assert utils.get_company_imdb_id(company_insert_statement) == "0002663"
print("- get company imdb_id test passed")
assert utils.get_company_name(company_insert_statement) == "Warner Bros."
print("- get company name test passed")

# Genre insert statement data retrieval tests
assert utils.get_genre_id(genre_insert_statement) == "19"
print("- get genre id test passed")
assert utils.get_genre_name(genre_insert_statement) == "Film-Noir"
print("- get genre name test passed")

# Language insert statement data retrieval tests
assert utils.get_language_id(language_insert_statement) == "30"
print("- get language id test passed")
assert utils.get_language_code(language_insert_statement) == "yi"
print("- get language code test passed")
assert utils.get_language_name(language_insert_statement) == "Yiddish"
print("- get language name test passed")

# Country insert statement data retrieval tests
assert utils.get_country_id(country_insert_statement) == "4"
print("- get country id test passed")
assert utils.get_country_code(country_insert_statement) == "es"
print("- get country code test passed")
assert utils.get_country_name(country_insert_statement) == "Spain"
print("- get country name test passed")

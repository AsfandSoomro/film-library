import unicodedata
import re

# Useful text conversion
def slugify(value, allow_unicode=False):
    """
    Taken from https://github.com/django/django/blob/master/django/utils/text.py
    Convert to ASCII if 'allow_unicode' is False. Convert spaces or repeated
    dashes to single dashes. Remove characters that aren't alphanumerics,
    underscores, or hyphens. Convert to lowercase. Also strip leading and
    trailing whitespace, dashes, and underscores.
    """
    """+ Edited according to my needs"""

    value = str(value)
    if allow_unicode:
        value = unicodedata.normalize('NFKC', value)
    else:
        value = unicodedata.normalize('NFKD', value).encode('ascii', 'ignore').decode('ascii')
    value = re.sub(r'[^\w\s-]', '', value)
    return re.sub(r'[-\s]+', '_', value).strip('-_') 

# Functions to retrieve values from Person Insert Statement
def get_person_id(person_insert_statement: str) -> str:
    return person_insert_statement.split("VALUES(")[1].strip(");").split(",")[0].strip(" '")
def get_person_imdb_id(person_insert_statement: str) -> str:
    return person_insert_statement.split("VALUES(")[1].strip(");").split(",")[1].strip(" '")
def get_person_name(person_insert_statement: str) -> str:
    return person_insert_statement.split("VALUES(")[1].strip(");").split(",")[2].strip(" '")

# Functions to retrieve values from Company Insert Statement
def get_company_id(company_insert_statement: str) -> str:
    return company_insert_statement.split("VALUES(")[1].strip(");").split(",")[0].strip(" '")
def get_company_imdb_id(company_insert_statement: str) -> str:
    return company_insert_statement.split("VALUES(")[1].strip(");").split(",")[1].strip(" '")
def get_company_name(company_insert_statement: str) -> str:
    return company_insert_statement.split("VALUES(")[1].strip(");").split(",")[2].strip(" '")

# Functions to retrieve values from Genre Insert Statement
def get_genre_id(genre_insert_statement: str) -> str:
    return genre_insert_statement.split("VALUES(")[1].strip(");").split(",")[0].strip(" '")
def get_genre_name(genre_insert_statement: str) -> str:
    return genre_insert_statement.split("VALUES(")[1].strip(");").split(",")[1].strip(" '")

# Functions to retrieve values from Language Insert Statement
def get_language_id(language_insert_statement: str) -> str:
    return language_insert_statement.split("VALUES(")[1].strip(");").split(",")[0].strip(" '")
def get_language_code(language_insert_statement: str) -> str:
    return language_insert_statement.split("VALUES(")[1].strip(");").split(",")[1].strip(" '")
def get_language_name(language_insert_statement: str) -> str:
    return language_insert_statement.split("VALUES(")[1].strip(");").split(",")[2].strip(" '")

# Functions to retrieve values from Country Insert Statement
def get_country_id(country_insert_statement: str) -> str:
    return country_insert_statement.split("VALUES(")[1].strip(");").split(",")[0].strip(" '")
def get_country_code(country_insert_statement: str) -> str:
    return country_insert_statement.split("VALUES(")[1].strip(");").split(",")[1].strip(" '")
def get_country_name(country_insert_statement: str) -> str:
    return country_insert_statement.split("VALUES(")[1].strip(");").split(",")[2].strip(" '")

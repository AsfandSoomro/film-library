from io import BytesIO
import base64
from PIL import Image
import re


def insert_movie(movie_id: int, imdb_id: str, title: str, plot_outline: str, release_year: int, rating: float, votes: int, cover_path: str, budget: int, cumulative_worldwide_gross: int) -> str:
    # Convert the image to bytearray from the given cover path
    #with open(cover_path, 'rb') as image:
        #cover = image_to_byte(image)
        #cover = image.read().hex()
    
    title = title.replace("'", "''")
    plot_outline = plot_outline.replace("'", "''")

    return f"INSERT INTO Movies (movie_id, imdb_id, title, plot_outline, release_year, rating, votes, budget, cumulative_worldwide_gross, cover) VALUES({movie_id}, '{imdb_id}', '{title}', '{plot_outline}', {release_year}, {rating}, {votes}, {re.sub(r'[^0-9]', '', budget) if budget else 'NULL'}, {re.sub(r'[^0-9]', '', cumulative_worldwide_gross) if cumulative_worldwide_gross else 'NULL'}, {'@cover' if cover_path else 'NULL'});" + f"\n{cover_path}"

def insert_person(person_id: int, imdb_id: str, name: str) -> str:
    name = name.replace("'", "''")
    return f"INSERT INTO Persons (person_id, imdb_id, name) VALUES({person_id}, '{imdb_id}', '{name}');"

def insert_company(company_id: int, imdb_id: str, name: str) -> str:
    name = name.replace("'", "''")
    return f"INSERT INTO Companies (company_id, imdb_id, name) VALUES({company_id}, '{imdb_id}', '{name}');"

def insert_genre(genre_id: int, name: str) -> str:
    name = name.replace("'", "''")
    return f"INSERT INTO Genres (genre_id, name) VALUES({genre_id}, '{name}');"

def insert_country(country_id: int, country_code: str, name: str) -> str:
    name = name.replace("'", "''")
    return f"INSERT INTO Countries (country_id, country_code, name) VALUES({country_id}, '{country_code}', '{name}');"

def insert_language(language_id: int, language_code: str, name: str) -> str:
    name = name.replace("'", "''")
    return f"INSERT INTO Languages (language_id, language_code, name) VALUES({language_id}, '{language_code}', '{name}');"

def insert_movies_directors(id: int, movie_id: int, director_id: int):
    return f"INSERT INTO Movies_Directors (id, movie_id, director_id) VALUES({id}, {movie_id}, {director_id});"

def insert_movies_producers(id: int, movie_id: int, producer_id: int):
    return f"INSERT INTO Movies_Producers (id, movie_id, producer_id) VALUES({id}, {movie_id}, {producer_id});"

def insert_movies_writers(id: int, movie_id: int, writer_id: int):
    return f"INSERT INTO Movies_Writers (id, movie_id, writer_id) VALUES({id}, {movie_id}, {writer_id});"

def insert_movies_cast(id: int, movie_id: int, cast_id: int):
    return f"INSERT INTO Movies_Cast (id, movie_id, cast_id) VALUES({id}, {movie_id}, {cast_id});"

def insert_movies_genres(id: int, movie_id: int, genre_id: int):
    return f"INSERT INTO Movies_Genres (id, movie_id, genre_id) VALUES({id}, {movie_id}, {genre_id});"

def insert_movies_countries(id: int, movie_id: int, country_id: int):
    return f"INSERT INTO Movies_Countries (id, movie_id, country_id) VALUES({id}, {movie_id}, {country_id});"

def insert_movies_languages(id: int, movie_id: int, language_id: int):
    return f"INSERT INTO Movies_Languages (id, movie_id, language_id) VALUES({id}, {movie_id}, {language_id});"

def insert_movies_companies(id: int, movie_id: int, company_id: int):
    return f"INSERT INTO Movies_Companies (id, movie_id, company_id) VALUES({id}, {movie_id}, {company_id});"

def insert_movies_distributors(id: int, movie_id: int, distributor_id: int):
    return f"INSERT INTO Movies_Distributors (id, movie_id, distributor_id) VALUES({id}, {movie_id}, {distributor_id});"


def image_to_byte(filepath):
    with Image.open(filepath) as img:
        buffer = BytesIO()
        img.save(buffer, format='JPEG')
        return base64.b64encode(buffer.getvalue())
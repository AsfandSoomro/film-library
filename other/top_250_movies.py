import os
from imdb import Cinemagoer
import wget

import generate

DIR = "./data/top_250_movies/"

# Create an instance of the Cinemagoer class
ia = Cinemagoer()

#try:
# List of top 250 movies in real time
top_movies = ia.get_top250_movies()

# Starting IDs
movie_id = 0
person_id = 0
director_id = 0
producer_id = 0
writer_id = 0
cast_id = 0
genre_id = 0
country_id = 0
language_id = 0
company_id = 0
p_company_id = 0
distributor_id = 0
curr_genre_id = 0
curr_country_id = 0
curr_language_id = 0
movie_director_id = 0
movie_producer_id = 0
movie_writer_id = 0
movie_cast_id = 0
movie_genre_id = 0
movie_country_id = 0
movie_language_id = 0
movie_company_id = 0
movie_distributor_id = 0

try:
    # Loop over each movie
    for i, movie in enumerate(top_movies):
        # Get the movie by searching with its IMDB ID
        print(f"{i}. Fetching data for {movie}...")
        movie = ia.get_movie(movie.movieID)

        print(f"{movie['original title']} ({movie['year']}) data fetched")

        # Open file, get Insert code and append in it
        with open(f"{DIR}/movies.txt", "a") as movie_file:
            
            cover_path = f"{DIR}/covers/{movie['original title'].replace(':', '')}.jpg"
            
            # Check if the directory exists, if not create it
            if not os.path.isdir(os.getcwd() + f"{DIR}/covers"):
                os.mkdir(os.getcwd() + f"{DIR}/covers")
            # Check if the cover photo already exists
            if not os.path.isfile(os.getcwd() + cover_path):
                # Download the full-size movie
                print('Downloading full-size cover photo')
                wget.download(movie['full-size cover url'], cover_path)
                print()

            # Trying on possible Empy fields
            try:
                budget = movie['box office']['Budget']
            except KeyError:
                budget = None
            try:
                cumulative_worldwide_gross = movie['box office']['Cumulative Worldwide Gross']
            except KeyError:
                cumulative_worldwide_gross = None

            # The line to append
            line = generate.insert_movie(
                movie_id=movie_id,
                imdb_id=movie['imdbID'],
                title=movie['original title'],
                plot_outline=movie['plot outline'],
                release_year=movie['year'],
                rating=movie['rating'],
                votes=movie['votes'],
                cover_path=f"{DIR.replace('.', '')}covers/{movie['original title'].replace(':', '')}.jpg",
                budget=budget,
                cumulative_worldwide_gross=cumulative_worldwide_gross
            )
            movie_file.write(line + "\n")

        # Open Genre file for reading and writing
        with open(f"{DIR}/genres.txt", 'a+') as genre_file:
            genre_file.seek(0) # To start
            file_data = genre_file.read()
            genre_file.seek(2) # Back to end
            
            for genre in movie["genres"]:

                if genre not in file_data:
                    line = generate.insert_genre(
                        genre_id=genre_id,
                        name=genre
                    )
                    genre_file.write(line + "\n")

                    curr_genre_id = genre_id
                    genre_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'): # INSERT INTO genre (genre_id, name) VALUES(1'Crime');, 
                        if not len(a_line) > 1:
                            break
                        name = a_line.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if name == genre:
                            curr_genre_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()
                
                with open(f"{DIR}/movies_genres.txt", 'a+') as movie_genre_file:
                    line = generate.insert_movies_genres(
                        id=movie_genre_id,
                        movie_id=movie_id,
                        genre_id=curr_genre_id
                    )
                    movie_genre_file.write(line + "\n")
                    movie_genre_id += 1

        # Open Country file for reading and writing
        with open(f"{DIR}/languages.txt", 'a+') as language_file:
            language_file.seek(0) # To start
            file_data = language_file.read()
            language_file.seek(2) # Back to end

            for i, language in enumerate(movie["languages"]):
                if language not in file_data:
                    line = generate.insert_language(
                        language_id=language_id,
                        language_code=movie["language codes"][i],
                        name=language
                    )
                    language_file.write(line + "\n")

                    curr_language_id = language_id
                    language_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        name = a_line.split("VALUES(")[1].strip(");").split(",")[2].strip("'")
                        if name == language:
                            curr_language_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()
                
                with open(f"{DIR}/movies_languages.txt", 'a+') as movie_language_file:
                    line = generate.insert_movies_languages(
                        id=movie_language_id,
                        movie_id=movie_id,
                        language_id=curr_language_id
                    )
                    movie_language_file.write(line + "\n")
                    movie_language_id += 1

        # Open Country file for reading and writing
        with open(f"{DIR}/countries.txt", 'a+') as country_file:
            country_file.seek(0) # To start
            file_data = country_file.read()
            country_file.seek(2) # Back to end

            for i, country in enumerate(movie["countries"]):
                if country not in file_data:
                    line = generate.insert_country(
                        country_id=country_id,
                        country_code=movie["country codes"][i],
                        name=country
                    )
                    country_file.write(line + "\n")

                    curr_country_id = country_id
                    country_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        name = a_line.split("VALUES(")[1].strip(");").split(",")[2].strip("'")
                        if name == country:
                            curr_country_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()
                
                with open(f"{DIR}/movies_countries.txt", 'a+') as movie_country_file:
                    line = generate.insert_movies_countries(
                        id=movie_country_id,
                        movie_id=movie_id,
                        country_id=curr_country_id
                    )
                    movie_country_file.write(line + "\n")
                    movie_country_id += 1

        # Open Person file for reading and writing for these Persons (Director, Producer, Writer, Cast)
        with open(f"{DIR}/persons.txt", 'a+') as person_file:

            # For each director append the insert query if director is not in person inserts
            person_file.seek(0) # To start
            file_data = person_file.read()
            person_file.seek(2) # Back to end
            for director in movie['director']:
                if director.personID not in file_data:
                    line = generate.insert_person(
                        person_id=person_id,
                        imdb_id=director.personID,
                        name=director['name']
                    )
                    person_file.write(line + "\n")

                    director_id = person_id
                    person_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = file_data.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if director.personID == imdb_id:
                            director_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()

                with open(f"{DIR}/movies_directors.txt", 'a+') as movie_director_file:
                    line = generate.insert_movies_directors(
                        id=movie_director_id,
                        movie_id=movie_id,
                        director_id=director_id
                    )
                    movie_director_file.write(line + "\n")
                    movie_director_id += 1


            # Now for producers
            person_file.seek(0) # To start
            file_data = person_file.read()
            person_file.seek(2) # Back to end
            for producer in movie['producer']:
                if producer.personID not in file_data:
                    line = generate.insert_person(
                        person_id=person_id,
                        imdb_id=producer.personID,
                        name=producer['name']
                    )
                    person_file.write(line + "\n")
                    
                    producer_id = person_id
                    person_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = file_data.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if producer.personID == imdb_id:
                            producer_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()

                with open(f"{DIR}/movies_producers.txt", 'a+') as movie_producer_file:
                    line = generate.insert_movies_producers(
                        id=movie_producer_id,
                        movie_id=movie_id,
                        producer_id=producer_id
                    )
                    movie_producer_file.write(line + "\n")
                    movie_producer_id += 1
            
            # Now for writers
            person_file.seek(0) # To start
            file_data = person_file.read()
            person_file.seek(2) # Back to end
            for writer in movie['writer']:
                if not writer:
                    continue
                if writer.personID not in file_data:
                    line = generate.insert_person(
                        person_id=person_id,
                        imdb_id=writer.personID,
                        name=writer['name']
                    )
                    person_file.write(line + "\n")
                    
                    writer_id = person_id
                    person_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = file_data.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if writer.personID == imdb_id:
                            writer_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()

                with open(f"{DIR}/movies_writers.txt", 'a+') as movie_writer_file:
                    line = generate.insert_movies_writers(
                        id=movie_writer_id,
                        movie_id=movie_id,
                        writer_id=writer_id
                    )
                    movie_writer_file.write(line + "\n")
                    movie_writer_id += 1
                    
            # Now for cast
            person_file.seek(0) # To start
            file_data = person_file.read()
            person_file.seek(2) # Back to end
            for cast in movie['cast']:
                if cast.personID not in file_data:
                    line = generate.insert_person(
                        person_id=person_id,
                        imdb_id=cast.personID,
                        name=cast['name']
                    )
                    person_file.write(line + "\n")
                    
                    cast_id = person_id
                    person_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = file_data.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if cast.personID == imdb_id:
                            cast_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()

                with open(f"{DIR}/movies_casts.txt", 'a+') as movie_cast_file:
                    line = generate.insert_movies_cast(
                        id=movie_cast_id,
                        movie_id=movie_id,
                        cast_id=cast_id
                    )
                    movie_cast_file.write(line + "\n")
                    movie_cast_id += 1

        # Open Company file for reading and writing for these Companies (Production Companies, distributors)
        with open(f"{DIR}/companies.txt", 'a+') as company_file:

            # For each production_company append the insert query if company is not in companies inserts
            company_file.seek(0) # To start
            file_data = company_file.read()
            company_file.seek(2) # Back to end
            for company in movie['production companies']:
                if company.companyID not in file_data:
                    line = generate.insert_company(
                        company_id=company_id,
                        imdb_id=company.companyID,
                        name=company['name']
                    )
                    company_file.write(line + "\n")

                    p_company_id = company_id
                    company_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = file_data.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if company.companyID == imdb_id:
                            p_company_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()

                with open(f"{DIR}/movies_companies.txt", 'a+') as movie_company_file:
                    line = generate.insert_movies_companies(
                        id=movie_company_id,
                        movie_id=movie_id,
                        company_id=p_company_id
                    )
                    movie_company_file.write(line + "\n")
                    movie_company_id += 1
            
            # For each distributor_company append the insert query if company is not in companies inserts
            company_file.seek(0) # To start
            file_data = company_file.read()
            company_file.seek(2) # Back to end
            for distributor in movie['distributors']:
                if distributor.companyID not in file_data:
                    line = generate.insert_company(
                        company_id=company_id,
                        imdb_id=distributor.companyID,
                        name=distributor['name']
                    )
                    company_file.write(line + "\n")

                    distributor_id = company_id
                    company_id += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = file_data.split("VALUES(")[1].strip(");").split(",")[1].strip("'")
                        if distributor.companyID == imdb_id:
                            distributor_id = a_line.split("VALUES(")[1].strip(");").split(",")[0].strip()

                with open(f"{DIR}/movies_distributors.txt", 'a+') as movie_distributor_file:
                    line = generate.insert_movies_distributors(
                        id=movie_distributor_id,
                        movie_id=movie_id,
                        distributor_id=distributor_id
                    )
                    movie_distributor_file.write(line + "\n")
                    movie_distributor_id += 1
        
        movie_id += 1
        print("Successfully generated insert statements\n")

    ''' print(movie['genres'])
        print(movie['full-size cover url'])
        print(movie['plot outline'])
        print(movie['votes'])
        print(movie['box office'])
        print(movie['year'])
        print(movie['kind'])
        print(movie['director'][0].personID, type(movie['director'][0].personID))
        print(movie['producer']) #writer #production company #dstributer
        print(movie['cast'])
        print(movie['languages']) # language codes
        print(movie['language codes'])
        print(movie['countries']) # country codes
        print(movie['country codes'])
        print(movie['thanks'])
        print(movie['akas']) '''

except Exception as e:
    print(e)
    
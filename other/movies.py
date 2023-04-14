import os
from imdb import Cinemagoer
import wget
import json

import generate
import utils

starting_ids_json_file_dir = os.getcwd() + "\\starting_ids.json"

def start(movies: list[Cinemagoer], directory: str):
    # Create an instance of the Cinemagoer class
    ia = Cinemagoer()

    # Get the starting IDs
    try:
        with open(starting_ids_json_file_dir, "r") as json_file:
            ids = json.load(json_file)
    except:
        print("Couldn't find starting ids")
        return

     # Loop over each movie
    for i, movie in enumerate(movies):
        # Get the movie by searching with its IMDB ID
        print(f"{i}. Fetching data for {movie}...")
        try:
            movie = ia.get_movie(movie.movieID)
        except:
            continue # Skip the movie if it couldn't be fetched

        print(f"{movie['original title']} ({movie['year']}) data fetched")

        # Open file, get Insert code and append in it
        with open(f"{directory}\\movies.txt", "a") as movie_file:
            
            cover_name = f"{utils.slugify(movie['original title'])}"
            cover_extension = ".jpg"
            cover_path = f"{directory}\\covers\\{cover_name}{cover_extension}"
            
            # Check if the directory exists, if not create it
            if not os.path.isdir(f"{directory}\\covers"):
                os.mkdir(f"{directory}\\covers")
            # Check if the cover photo already exists
            if not os.path.isfile(cover_path):
                # Download the full-size movie
                print('Downloading full-size cover photo')
                wget.download(movie['full-size cover url'], cover_path)
                print()
            else:
                print('Full-size cover photo is already in the directory, continuing...')

            # Trying on possible Empty fields
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
                movie_id=ids['movie_id'],
                imdb_id=movie['imdbID'],
                title=movie['original title'],
                plot_outline=movie['plot outline'],
                release_year=movie['year'],
                rating=movie['rating'],
                votes=movie['votes'],
                cover_path=cover_path,
                budget=budget,
                cumulative_worldwide_gross=cumulative_worldwide_gross
            )
            movie_file.write(line + "\n")

        # Check if movie's genres are provided, then open Genre file for reading and writing
        try:
            genres = movie['genres']
        except KeyError:
            genres = None
        if genres:
            with open(f"{directory}/genres.txt", 'a+') as genre_file:
                genre_file.seek(0) # To start
                file_data = genre_file.read()
                genre_file.seek(2) # Back to end
                
                for genre in genres:

                    if genre not in file_data:
                        line = generate.insert_genre(
                            genre_id=ids['genre_id'],
                            name=genre
                        )
                        genre_file.write(line + "\n")

                        ids['curr_genre_id'] = ids['genre_id']
                        ids['genre_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'): # INSERT INTO genre (genre_id, name) VALUES(1'Crime');, 
                            if not len(a_line) > 1:
                                break
                            name = utils.get_genre_name(a_line)
                            if name == genre:
                                ids['curr_genre_id'] = int(utils.get_genre_id(a_line))
                                break
                    
                    with open(f"{directory}/movies_genres.txt", 'a+') as movie_genre_file:
                        line = generate.insert_movies_genres(
                            id=ids['movie_genre_id'],
                            movie_id=ids['movie_id'],
                            genre_id=ids['curr_genre_id']
                        )
                        movie_genre_file.write(line + "\n")
                        ids['movie_genre_id'] += 1

        # Check of movie's languages are provided, then open Languages file for reading and writing
        try:
            languages = movie['languages']
        except KeyError:
            languages = None
        if languages:
            with open(f"{directory}/languages.txt", 'a+') as language_file:
                language_file.seek(0) # To start
                file_data = language_file.read()
                language_file.seek(2) # Back to end

                for i, language in enumerate(languages):
                    if language not in file_data:
                        line = generate.insert_language(
                            language_id=ids['language_id'],
                            language_code=movie["language codes"][i],
                            name=language
                        )
                        language_file.write(line + "\n")

                        ids['curr_language_id'] = ids['language_id']
                        ids['language_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'):
                            if not len(a_line) > 1:
                                break
                            name = utils.get_language_name(a_line)
                            if name == language:
                                ids['curr_language_id'] = utils.get_language_id(a_line)
                                break
                    
                    with open(f"{directory}/movies_languages.txt", 'a+') as movie_language_file:
                        line = generate.insert_movies_languages(
                            id=ids['movie_language_id'],
                            movie_id=ids['movie_id'],
                            language_id=ids['curr_language_id']
                        )
                        movie_language_file.write(line + "\n")
                        ids['movie_language_id'] += 1

        # Check if the movie's countries are provided, then open Country file for reading and writing
        try:
            countries = movie['countries']
        except:
            countries = None
        if countries:
            with open(f"{directory}/countries.txt", 'a+') as country_file:
                country_file.seek(0) # To start
                file_data = country_file.read()
                country_file.seek(2) # Back to end

                for i, country in enumerate(countries):
                    if country not in file_data:
                        line = generate.insert_country(
                            country_id=ids['country_id'],
                            country_code=movie["country codes"][i],
                            name=country
                        )
                        country_file.write(line + "\n")

                        ids['curr_country_id'] = ids['country_id']
                        ids['country_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'):
                            if not len(a_line) > 1:
                                break
                            name = utils.get_country_name(a_line)
                            if name == country:
                                ids['curr_country_id'] = int(utils.get_country_id(a_line))
                                break
                    
                    with open(f"{directory}/movies_countries.txt", 'a+') as movie_country_file:
                        line = generate.insert_movies_countries(
                            id=ids['movie_country_id'],
                            movie_id=ids['movie_id'],
                            country_id=ids['curr_country_id']
                        )
                        movie_country_file.write(line + "\n")
                        ids['movie_country_id'] += 1

        # Open Person file for reading and writing for these Persons (Director, Producer, Writer, Cast)
        with open(f"{directory}/persons.txt", 'a+') as person_file:

            # For each director append the insert query if director is not in person inserts
            try:
                directors = movie['director']
            except KeyError:
                directors = None
            if directors:
                person_file.seek(0) # To start
                file_data = person_file.read()
                person_file.seek(2) # Back to end
                for director in directors:
                    if director.personID not in file_data:
                        line = generate.insert_person(
                            person_id=ids['person_id'],
                            imdb_id=director.personID,
                            name=director['name']
                        )
                        person_file.write(line + "\n")

                        ids['director_id']  = ids['person_id'] 
                        ids['person_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'):
                            if not len(a_line) > 1:
                                break
                            imdb_id = utils.get_person_imdb_id(a_line)
                            if director.personID == imdb_id:
                                ids['director_id']  = int(utils.get_person_id(a_line))
                                break

                    with open(f"{directory}/movies_directors.txt", 'a+') as movie_director_file:
                        line = generate.insert_movies_directors(
                            id=ids['movie_director_id'],
                            movie_id=ids['movie_id'],
                            director_id=ids['director_id'] 
                        )
                        movie_director_file.write(line + "\n")
                        ids['movie_director_id'] += 1


            # Now for producers
            try:
                producers = movie["producer"]
            except KeyError:
                producers = None
            if producers:
                person_file.seek(0) # To start
                file_data = person_file.read()
                person_file.seek(2) # Back to end
                for producer in producers:
                    if producer.personID not in file_data:
                        line = generate.insert_person(
                            person_id=ids['person_id'],
                            imdb_id=producer.personID,
                            name=producer['name']
                        )
                        person_file.write(line + "\n")
                        
                        ids['producer_id']  = ids['person_id'] 
                        ids['person_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'):
                            if not len(a_line) > 1:
                                break
                            imdb_id = utils.get_person_imdb_id(a_line)
                            if producer.personID == imdb_id:
                                ids['producer_id']  = utils.get_person_id(a_line)
                                break

                    with open(f"{directory}/movies_producers.txt", 'a+') as movie_producer_file:
                        line = generate.insert_movies_producers(
                            id=ids['movie_producer_id'],
                            movie_id=ids['movie_id'],
                            producer_id=ids['producer_id'] 
                        )
                        movie_producer_file.write(line + "\n")
                        ids['movie_producer_id'] += 1
            
            # Now for writers
            try:
                writers = movie["writer"]
            except KeyError:
                writers = None
            if writers:
                person_file.seek(0) # To start
                file_data = person_file.read()
                person_file.seek(2) # Back to end        
                for writer in writers:
                    if not writer:
                        continue
                    if writer.personID not in file_data:
                        line = generate.insert_person(
                            person_id=ids['person_id'],
                            imdb_id=writer.personID,
                            name=writer['name']
                        )
                        person_file.write(line + "\n")
                        
                        ids['writer_id'] = ids['person_id'] 
                        ids['person_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'):
                            if not len(a_line) > 1:
                                break
                            imdb_id = utils.get_person_imdb_id(a_line)
                            if writer.personID == imdb_id:
                                ids['writer_id'] = utils.get_person_id(a_line)
                                break

                    with open(f"{directory}/movies_writers.txt", 'a+') as movie_writer_file:
                        line = generate.insert_movies_writers(
                            id=ids['movie_writer_id'],
                            movie_id=ids['movie_id'],
                            writer_id=ids['writer_id']
                        )
                        movie_writer_file.write(line + "\n")
                        ids['movie_writer_id'] += 1
                    
            # Now for cast
            try:
                casts = movie['cast']
            except KeyError:
                casts = None
            if casts:
                person_file.seek(0) # To start
                file_data = person_file.read()
                person_file.seek(2) # Back to end
                for cast in casts:
                    if cast.personID not in file_data:
                        line = generate.insert_person(
                            person_id=ids['person_id'],
                            imdb_id=cast.personID,
                            name=cast['name']
                        )
                        person_file.write(line + "\n")
                        
                        ids['cast_id'] = ids['person_id'] 
                        ids['person_id'] += 1
                    elif file_data:
                        for a_line in file_data.split('\n'):
                            if not len(a_line) > 1:
                                break
                            imdb_id = utils.get_person_imdb_id(a_line)
                            if cast.personID == imdb_id:
                                ids['cast_id'] = utils.get_person_id(a_line)
                                break

                    with open(f"{directory}/movies_casts.txt", 'a+') as movie_cast_file:
                        line = generate.insert_movies_cast(
                            id=ids['movie_cast_id'],
                            movie_id=ids['movie_id'],
                            cast_id=ids['cast_id']
                        )
                        movie_cast_file.write(line + "\n")
                        ids['movie_cast_id'] += 1

        # Open Company file for reading and writing for these Companies (Production Companies, distributors)
        with open(f"{directory}/companies.txt", 'a+') as company_file:

            # For each production_company append the insert query if company is not in companies inserts
            company_file.seek(0) # To start
            file_data = company_file.read()
            company_file.seek(2) # Back to end
            for company in movie['production companies']:
                if company.companyID not in file_data:
                    line = generate.insert_company(
                        company_id=ids['company_id'],
                        imdb_id=company.companyID,
                        name=company['name']
                    )
                    company_file.write(line + "\n")

                    ids['p_company_id'] = ids['company_id']
                    ids['company_id'] += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = utils.get_company_imdb_id(a_line)
                        if company.companyID == imdb_id:
                            ids['p_company_id'] = utils.get_company_id(a_line)
                            break

                with open(f"{directory}/movies_companies.txt", 'a+') as movie_company_file:
                    line = generate.insert_movies_companies(
                        id=ids['movie_company_id'],
                        movie_id=ids['movie_id'],
                        company_id=ids['p_company_id']
                    )
                    movie_company_file.write(line + "\n")
                    ids['movie_company_id'] += 1
            
            # For each distributor_company append the insert query if company is not in companies inserts
            company_file.seek(0) # To start
            file_data = company_file.read()
            company_file.seek(2) # Back to end
            for distributor in movie['distributors']:
                if distributor.companyID not in file_data:
                    line = generate.insert_company(
                        company_id=ids['company_id'],
                        imdb_id=distributor.companyID,
                        name=distributor['name']
                    )
                    company_file.write(line + "\n")

                    ids['distributor_id'] = ids['company_id']
                    ids['company_id'] += 1
                elif file_data:
                    for a_line in file_data.split('\n'):
                        if not len(a_line) > 1:
                            break
                        imdb_id = utils.get_company_imdb_id(a_line)
                        if distributor.companyID == imdb_id:
                            ids['distributor_id'] = utils.get_company_id(a_line)
                            break

                with open(f"{directory}/movies_distributors.txt", 'a+') as movie_distributor_file:
                    line = generate.insert_movies_distributors(
                        id=ids['movie_distributor_id'],
                        movie_id=ids['movie_id'],
                        distributor_id=ids['distributor_id']
                    )
                    movie_distributor_file.write(line + "\n")
                    ids['movie_distributor_id'] += 1
        
        ids['movie_id'] += 1

        # Storing the updated ID values in the same json file
        with open(starting_ids_json_file_dir, 'w') as json_file:
            json.dump(ids, json_file, indent=4)

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
import os
from imdb import Cinemagoer

import movies

DIR = os.getcwd() + "\\data\\top_250_movies\\"
# Check if the folder exists, if not create one
if (not os.path.isdir(DIR)):
    os.mkdir(DIR)

# Create an instance of the Cinemagoer class
ia = Cinemagoer()

# List of top 250 movies in real time
top_movies = ia.get_top250_movies()

# Starts the fetching, code generating process and saves in files in the directory
try:
   movies.start(
       movies=top_movies,
       directory=DIR
   )
   print("Successfully generated data and related data of all 250 movies")
except Exception as e:
    print(e)
    
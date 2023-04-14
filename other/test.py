from imdb import Cinemagoer
import wget

ia = Cinemagoer()

#movie = ia.search_movie("The Lord of the Rings The Return of the King")
movie = ia.get_movie("0167261")

wget.download(movie['full-size cover url'], f"./The Lord of the Rings The Two Towers.jpg")
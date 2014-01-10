using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager {
    class Movie {
        enum Quality    {
            Rip,
            Standard,
            HD,
            FullHD
        }

        //File Related Information
        private String filePath;
        private String name;
        private Quality quality;
        
        //Content Related Information
        private double imdbRating;
        private String imdbLink;
        private List<String> imdbGenre;

        //Creator Related Information
        private Person director;
        private List<Person> actors;

        //Constructors
        public Movie() {

        }
        public Movie(String path, String name) {
            
        }
        public Movie(String path, String name, Quality quality) {

        }
        public Movie(String path, String name, Quality quality, Person director, List<Person> actors) {

        }

        //Static Methods
        public static Movie movieFromPath(String path) {
            return null;
        }

        //Getter and Setter


        //Methods
        public void play() {
            //Playing a Movie File from here is very complicated and requires a higher knowledge of C#
            //Noted for later use
        }

        public String toString() {

            return null;
        }

        public Boolean equals(Movie m) {
            return false;
        }

        public void getIMDBRating() {

        }

        public void getIMDBLink() {

        }

        public void getIMDBGenre() {

        }
    }
}

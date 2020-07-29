
using Lab11_5;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab11_5
{
    class SakilaContext : DbContext
    {

        public DbSet<Film> Film { get; set; }
    }
}
class Film
{
    [Key]
    public int film_id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string release_year { get; set; }
    public byte language_id { get; set; }
    public byte original_language_id { get; set; }
    public byte rental_duration { get; set; }
    public decimal rental_rate { get; set; }
    public Int16 length { get; set; }
    public decimal replacement_cost { get; set; }
    public string rating { get; set; }
    public string special_features { get; set; }
    public DateTime last_update { get; set; }

    public Film(string title, string description, string release_year, byte rental_duration,
        decimal rental_rate, Int16 length, decimal replacement_cost, string rating)
    {
        this.title = title;
        this.description = description;
        this.release_year = release_year;
        this.rental_duration = rental_duration;
        this.rental_rate = rental_rate;
        this.length = length;
        this.replacement_cost = replacement_cost;
        this.rating = rating;

        special_features = "Trailers";
        last_update = DateTime.Now;
        language_id = 1;
        original_language_id = 1;

    }

}
class Program
{
    static void Main(string[] args)
    {
        SakilaContext sakila = new SakilaContext();
        Film war1917 = new Film("1917", "2019 War Drama By Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
        Film joker = new Film("Joker", "Oscar-Nominated SuperHero Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
        Film jarjarAbrams = new Film("Star Wars: The Rise of SkyWalker", "Trash Disney Fanfic", "2019", 3, 4.99m, 202, 21.99m, "PG-13");

        sakila.Film.Add(war1917);
        sakila.Film.Add(joker); 
        sakila.Film.Add(jarjarAbrams);
        sakila.SaveChanges();

        


        Film[] allfilms = sakila.Film.ToArray();
     
        var newfilms = allfilms.Where(x => x.release_year == "2019");

        StringBuilder html = new StringBuilder();
        html.Append("<html>\n");
        html.Append("  <head>");
        html.Append("    <title>Sakila New Films</title>\n");
        html.Append("  </head>\n");
        html.Append("  <body\n");
        html.Append("    <h1> New Films Coming Soon! </h1>\n");
        html.Append("      <ul>\n");
        foreach (var film in newfilms)
        {
            html.Append("<li>");
            html.Append(film.title + " " + film.description);
            html.Append("</li>");
        }


        html.Append("      </ul>\n");
        html.Append("  </body>\n");
        html.Append("</html>\n");

        string htmlFile = "D:\\output\\newfilms.html";
        File.WriteAllText(htmlFile, html.ToString());
    }
}
namespace MoviesApi.Services
{
    public interface IGenresService
    {
        Task<IEnumerable<Genre>> GetAll(); //return all Genres from database
        Task<Genre> GetById(byte id);
        Task<Genre> Add(Genre genre); //Create one genre
        Genre Update(Genre genre); //Update genre
        Genre Delete(Genre genre); //Delete genre
        Task<bool> IsValidGenre(byte id);
    }
}

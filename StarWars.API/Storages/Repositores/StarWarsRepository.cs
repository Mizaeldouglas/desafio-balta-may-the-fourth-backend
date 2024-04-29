using System;
using Microsoft.EntityFrameworkCore;
using StarWars.API.Models;
using StarWars.API.Storages.Datas;

namespace StarWars.API.Storages.Repositores
{
    public class StarWarsRepository : IStarWarsRepository
    {
        private readonly StarWarsContext _context;

        public StarWarsRepository(StarWarsContext context)
        {
            _context = context;
        }

        public async Task<MovieModel?> CreateMovieAsync(
            MovieModel model,
            CancellationToken cancellationToken = default)
        {
            _context.Movies.Add(model);

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result == 0 ? null : model;
        }

        public async Task<List<MovieModel>?> GetMoviesAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _context.Movies.ToListAsync(cancellationToken);

            return response;
        }

        public async Task<MovieModel?> GetMovieByIdAsync(
            int movieId, CancellationToken cancellationToken = default)
        {
            var response = await _context.Movies.Where(x=> x.MovieId == movieId)
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }

        public async Task<List<CharacterModel>?> GetCharactersAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _context.Characters.ToListAsync(cancellationToken);
            return response;
        }

        public async Task<CharacterModel?> GetCharacterByIdAsync(
            int characterId, 
            CancellationToken cancellationToken = default)
        {
           var response = await _context.Characters.Where(x => x.CharacterId == characterId)
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }

        public async Task<CharacterModel?> CreateCharacterAsync(CharacterModel model, CancellationToken cancellationToken = default)
        {
            _context.Characters.Add(model);

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result == 0 ? null : model;
        }

        public async Task<PlanetModel?> GetPlanetByIdAsync(
            int planetId,
            CancellationToken cancellationToken = default)
        {
            var response = await _context.Planet.Where(x => x.PlanetId == planetId)
                 .FirstOrDefaultAsync(cancellationToken);

            await Task.Delay(0);

            return null;
        }

        public async Task<PlanetModel?> CreatePlanetAsync(PlanetModel model, CancellationToken cancellationToken = default)
        {
            _context.Planet.Add(model);

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result == 0 ? null : model;
        }
     
        public async Task<List<VehicleModel>?> GetVehicleAsync(
            CancellationToken cancellationToken = default)
        {
            var response = await _context.Vehicles.ToListAsync(cancellationToken);

            return response;

        public async Task<StarshipModel?> GetStarshipByIdAsync(
           int starshipId,
           CancellationToken cancellationToken = default)
        {
            var response = await _context.Spaceships.Where(x => x.StarshipId == starshipId)
                 .FirstOrDefaultAsync(cancellationToken);

            await Task.Delay(0);

            return null;
        }

        public async Task<StarshipModel?> CreateStarshipAsync(StarshipModel model, CancellationToken cancellationToken = default)
        {
            _context.Spaceships.Add(model);

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result == 0 ? null : model;
        }
    }
}


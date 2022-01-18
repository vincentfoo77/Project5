using Project5.Server.Data;
using Project5.Server.IPRes;
using Project5.Server.Models;
using Project5.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private Gen<Event_Details> _Details;
        private Gen<Attendees> _Attendee;
        private Gen<Category> _Category;
        private Gen<Events> _events;
        private Gen<Registration> _Registration;
        private Gen<Students> _Student;
        private Gen<Teachers> _teacher;
        private Gen<Venue> _venue;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public Gen<Event_Details> Details
            => _Details ??= new GenericRepository<Event_Details>(_context);
        public Gen<Attendees> Attendee
            => _Attendee ??= new GenericRepository<Attendees>(_context);
        public Gen<Category> Category
            => _Category ??= new GenericRepository<Category>(_context);
        public Gen<Events> events
            => _events ??= new GenericRepository<Events>(_context);
        public Gen<Registration> Registration
            => _Registration ??= new GenericRepository<Registration>(_context);
        public Gen<Students> Student
            => _Student ??= new GenericRepository<Students>(_context);
        public Gen<Teachers> teacher
            => _teacher ??= new GenericRepository<Teachers>(_context);
        public Gen<Venue> venue
            => _venue ??= new GenericRepository<Venue>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            await _context.SaveChangesAsync();
        }
    }
}
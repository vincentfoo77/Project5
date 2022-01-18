using Project5.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project5.Server.IPRes
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        Gen<Event_Details> Details { get; }
        Gen<Attendees> Attendee { get; }
        Gen<Category> Category { get; }
        Gen<Events> events { get; }
        Gen<Registration> Registration { get; }
        Gen<Students> Student { get; }
        Gen<Teachers> teacher { get; }
        Gen<Venue> venue { get; }
    }
}

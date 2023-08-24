using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWPub.Api.Entites;
using JWPub.Api.Repositories;

namespace JWPub.Api.Routes
{
    public static class PublisherRoute
    {
        public static RouteGroupBuilder PublisherRouteEndpoints(this IEndpointRouteBuilder routes){
            var group =  routes.MapGroup("/publishers");
            
            group.MapGet("/", async (IPublisherRepository repository) => await repository.GetAllAsync());
            group.MapGet("/{id}", async (IPublisherRepository repository, Guid id) => await repository.GetAsync(id));
            group.MapPut("/{id}", async (IPublisherRepository repository, Guid id, Publisher newPublisher) =>{
                await repository.UpdateAsync(newPublisher,id);
            });
            group.MapPost("/", async (IPublisherRepository repository, Publisher newPublisher)=> await repository.CreateAsync(newPublisher));
            group.MapDelete("/{id}", async (IPublisherRepository repository, Guid id)=> await repository.DeleteAsync(id));

            return group;
        }

    }
}
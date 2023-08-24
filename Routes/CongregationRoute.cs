using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWPub.Api.Entites;
using JWPub.Api.Repositories;

namespace JWPub.Api.Routes
{
    public static class CongregationRoute
    {
        public static RouteGroupBuilder CongregationRouteEndpoints(this IEndpointRouteBuilder routes){
            var group = routes.MapGroup("/congregations");
            group.MapGet("/",async (ICongregationRepository repo)=> await repo.GetAllAsync());
            group.MapGet("/{id}",async (ICongregationRepository repo, Guid id)=> await repo.GetAsync(id));
            group.MapPut("/{id}",async (ICongregationRepository repo, Guid id,Congregation congregation)=> await repo.UpdateAsync(id, congregation));
            group.MapPost("/",async(ICongregationRepository repo,Congregation congregation)=> await repo.CreateAsync(congregation));
            group.MapDelete("/{id}",async(ICongregationRepository repo, Guid id) => await repo.DeleteAsync(id));
            return group;
        }
    }
}
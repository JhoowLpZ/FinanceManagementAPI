﻿using Microsoft.AspNetCore.Routing;

namespace Presentation.Endpoints
{
    public interface IEndpoint
    {
        void MapEndpoints(IEndpointRouteBuilder endpoints);
    }
}

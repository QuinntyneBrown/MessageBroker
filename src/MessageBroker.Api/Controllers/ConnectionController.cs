// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace MessageBroker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class ConnectionController
{
    private readonly IMediator _mediator;

    private readonly ILogger<ConnectionController> _logger;

    public ConnectionController(IMediator mediator,ILogger<ConnectionController> logger){
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    [Route("/connect")]
    public async Task<IActionResult> Connect(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

}


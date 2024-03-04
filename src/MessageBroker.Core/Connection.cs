// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;

namespace MessageBroker.Core;

public class Connection: IConnection
{
    private readonly ILogger<Connection> _logger;

    public Connection(ILogger<Connection> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public ISubscriber GetSubscriber()
    {
       throw new NotImplementedException();

    }

    public static Connection Connect(string url)
    {
        throw new NotImplementedException();
    }

}


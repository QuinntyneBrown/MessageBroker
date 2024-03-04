// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;

namespace MessageBroker.Core;

public class Subscriber: ISubscriber
{
    private readonly ILogger<Subscriber> _logger;

    public Subscriber(ILogger<Subscriber> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task PublishAsync(byte[] buffer)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(string channel, Action<string, byte[]> callback)
    {
        throw new NotImplementedException();
    }
}


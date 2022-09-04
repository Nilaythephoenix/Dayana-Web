﻿using Dayana.Shared.Basic.MethodsAndObjects.Models;
using Dayana.Shared.Infrastructure.Operations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayana.Shared.Persistence.Models.Identity.Queries;
public class GetUserProfileQuery : IRequestInfo, IRequest<OperationResult>
{
    public GetUserProfileQuery(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }
    public int UserId { get; set; }
    public RequestInfo RequestInfo { get; private set; }
}

public class RefreshTokenQuery : IRequestInfo, IRequest<OperationResult>
{
    public RequestInfo RequestInfo { get; private set; }
    public RefreshTokenQuery(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }
    public string RefreshToken { get; set; }
}
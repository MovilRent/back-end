﻿namespace SocialMed.API.Shared.Domain.Services.Communication;

public abstract  class BaseResponse<T>
{
    protected BaseResponse(string message)
    {
        Success = false;
        Message = message;
        Resource = default;
    }
    
    protected BaseResponse(T resource)
    {
        Success = false;
        Message = string.Empty;
        Resource = resource;
    }

    public string Message { get; set; }
    public T Resource { get; set; }
    public bool Success { get; set; }
}
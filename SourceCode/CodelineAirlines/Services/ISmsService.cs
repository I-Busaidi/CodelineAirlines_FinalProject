﻿
namespace CodelineAirlines.Services
{
    public interface ISmsService
    {
        Task SendSmsAsync(string to, string message);
    }
}
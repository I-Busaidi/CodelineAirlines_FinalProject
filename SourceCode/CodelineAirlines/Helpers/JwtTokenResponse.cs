﻿namespace CodelineAirlines.Helpers
{
    public class JwtTokenResponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}

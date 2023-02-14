using System;
using System.Collections.Generic;
using System.Linq;
using IPE.SmsIrClient.Models.Requests;
using IPE.SmsIrClient;
using Microsoft.Extensions.Configuration;
using SmsIrRestful;

namespace _0_Framework.Application.Sms
{
    public class SmsService : ISmsService
    {
        private readonly IConfiguration _configuration;

        public SmsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async void Send(string number, string message)
        {
            
            SmsIr smsIr = new SmsIr("Your Api Key");

            var bulkSendResult = await smsIr.BulkSendAsync(000, message, new string[] {number.Substring(1)});


        }

        
    }
}
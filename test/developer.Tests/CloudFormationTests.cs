
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;

using Amazon;
using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.TestUtilities;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace lambda.Tests
{
    public class cloud_formation_tests
    {



        [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Invalid_JSON_Causes_Failure_During_Compilation()
        {

        }
    }
}
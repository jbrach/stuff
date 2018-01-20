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
    public class DynamoTests
    {
        


        [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Dynamo_LimitExceededExceptionError_When_CreatingSecondTable_Before_First_Active()
        {

        }

           [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Dynamo_Exceed_Individual_Throughput_Test()
        {

        }

        
    }
}
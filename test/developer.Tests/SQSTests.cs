
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
    public class SQSTests
    {



        [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Message_Available_Right_Away_When_VisibilityTimeout_Equal_Zero()
        {

        }



          [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Message_Fails_When_Size_Greater_Than_256K()
        {

        }

           [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Message_Succeeds_When_Size_Less_Than_256K()
        {

        }

            [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Message_Delivered_Twice_When()
        {

        }

             [Fact]
        /// <summary>
        /// Test Visibility Timeout == 0 
        /// </summary>
        public void Message_Delivered_Twice_When_X_Occurs()
        {

        }

          [Fact]
        /// <summary>
        /// SQS may delvier message more than once.!--   
        /// And can be in an ramdom order
        /// Testing that a Condition exists to deliver message more than once.!--   
        /// 
        /// </summary>
         public void MessagesAreAbleToBeDeliveredMoreThanOnce_When_Error_Condition(){
        
        }


        [Fact]
        /// <summary>
        /// SQS Retains message fro 30 days.  Test shows greater than 30 seconds
        /// Think about using SWF to test 30 days
        /// </summary>
         public void MessagesAreRetained_When_GreaterThan30Seconds(){
        
        }



       



    }
}
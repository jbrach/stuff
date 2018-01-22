using System.Linq;
using Xunit;
using Amazon.S3;
using Amazon;

namespace developer.Tests
{
    public class S3Tests
    {

        /// <summary>
        /// 
        /// When developing credentials should never be in source
        /// 
        /// Tests that you have default developer credentials setup on your machine
        /// 
        /// Install AWS Tools for Powershell if you have not
        /// https://docs.aws.amazon.com/powershell/latest/userguide/shared-credentials-in-aws-powershell.html
        /// 
        /// View the list of credentials setup Get-AWSCredential -ListProfileDetail
        /// 
        /// Create credential store power shell comment Amazon.Util.ProfileManager.RegisterProfile(StoreName, key, token)
        /// https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/net-dg-config-creds.html
        /// 
        /// Register your default credentials
        /// 
        /// Run this test
        /// </summary>
        [Fact]

        public async void Develper_Access_S3_Buckets_When_Default_Credentials_Are_Set_Up_TestAsync()
        {
           
            using (var client = new AmazonS3Client(RegionEndpoint.USEast2))
            {
                var response = await client.ListBucketsAsync();
                var count =response.Buckets.Count();

            }
        }
      
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;

using Amazon.Auth;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Lambda.Core;
using Amazon.S3;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.TestUtilities;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.S3.Model;

namespace developer.Tests
{
    public class S3Tests
    {
        [Fact]
        public void Given_Account_ListS3_Buckets_Securely()
        {


            //https://docs.aws.amazon.com/sdk-for-net/v2/developer-guide/net-dg-config-creds.html
            //Storing Credentials on Machine.   Not checked into source control
            //How does this run in our dev environment
            //Circle 
            IAmazonS3 client  null;
            //=new AmazonS3Client(new SharedCredentialsFile("JoeBrach"));

            //   NameValueCollection appConfig = ConfigurationManager.AppSettings;
            //   string accessKeyID = appConfig["AWSAccessKey"];
            //   string secretAccessKeyID = appConfig["AWSSecretKey"];
            //Given

            //When

            //Then
        }


        public async void GetBucketContentsAsync(string bucketName, IAmazonS3 client)
        {


            try
            {
                Console.WriteLine("Listing objects stored in a bucket");
                SessionAWSCredentials tempCredentials = null;
                // GetTemporaryCredentials(client.);

                // Create client by providing temporary security credentials.
                using (client = new AmazonS3Client(tempCredentials, Amazon.RegionEndpoint.USEast1))
                {
                    var request = new ListObjectsV2Request()
                    {
                        BucketName = bucketName,
                        MaxKeys = 10
                    };
                    ListObjectsV2Response response;

                    do
                    {
                        // Send request to Amazon S3.
                        response = await client.ListObjectsV2Async(request);
                        request.ContinuationToken = response.NextContinuationToken;
                    } while (response.IsTruncated == true);

                    var objects = response.S3Objects.ToList();
                    Console.WriteLine("Object count = {0}", objects.Count);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            catch (AmazonS3Exception s3Exception)
            {
                Console.WriteLine(s3Exception.Message,
                                  s3Exception.InnerException);
            }
            catch (Exception stsException)
            {
                Console.WriteLine(stsException.Message,
                                 stsException.InnerException);
            }
        }

        private static SessionAWSCredentials GetTemporaryCredentials(
                         string accessKeyId, string secretAccessKeyId)
        {
            AmazonSecurityTokenServiceClient stsClient =
                new AmazonSecurityTokenServiceClient(accessKeyId,
                                                     secretAccessKeyId);

            GetSessionTokenRequest getSessionTokenRequest =
                                             new GetSessionTokenRequest();
            getSessionTokenRequest.DurationSeconds = 7200; // seconds

            GetSessionTokenResponse sessionTokenResponse =
                          stsClient.GetSessionToken(getSessionTokenRequest);
            Credentials credentials = sessionTokenResponse.Credentials;

            SessionAWSCredentials sessionCredentials =
                new SessionAWSCredentials(credentials.AccessKeyId,
                                          credentials.SecretAccessKey,
                                          credentials.SessionToken);

            return sessionCredentials;
        }
    }
}
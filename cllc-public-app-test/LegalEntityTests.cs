﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

using System.Text;
using Newtonsoft.Json;
using System.Net;
using Gov.Lclb.Cllb.Interfaces.Microsoft.Dynamics.CRM;
using Gov.Lclb.Cllb.Public.Models;
using System.Net.Http.Headers;

namespace Gov.Lclb.Cllb.Public.Test
{
	public class LegalEntityTests : ApiIntegrationTestBaseWithLogin
    {
        public LegalEntityTests(CustomWebApplicationFactory<Startup> factory)
          : base(factory)
        { }

        [Fact]
        public async System.Threading.Tasks.Task TestNoAccessToAnonymousUser()
        {
            string service = "adoxiolegalentity";
            string id = "SomeRandomId";

            // first confirm we are not logged in
            await GetCurrentUserIsUnauthorized();

            // try a random GET, should return unauthorized
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + id);
            var response = await _client.SendAsync(request);
            Assert.Equal(response.StatusCode, HttpStatusCode.Unauthorized);
            string _discard = await response.Content.ReadAsStringAsync();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestCRUD()
        {
            string changedName = "ChangedName";
            string service = "adoxiolegalentity";
            string firstName = "First";
            string middleName = "Middle";
            string lastName = "Last";
            string initialName = firstName + " " + lastName;
            DateTime dateOfBirth = DateTime.Now;
            int commonNonVotingshares = 3000;
            int commonVotingshares = 1000;
            int isIndividual = 1;


            await LoginAsDefault();

            // C - Create
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/" + service);

            Adoxio_legalentity adoxio_legalentity = new Adoxio_legalentity()
            {
                //Adoxio_legalentityid = Guid.NewGuid(),
                Adoxio_legalentitytype = (int?)ViewModels.Adoxio_applicanttypecodes.PrivateCorporation,
                Adoxio_position = (int?)ViewModels.PositionOptions.Director,
                Adoxio_name = initialName,
                Adoxio_firstname = firstName,
                Adoxio_middlename = middleName,
                Adoxio_lastname = lastName,
                Adoxio_commonnonvotingshares = commonNonVotingshares,
                Adoxio_commonvotingshares = commonVotingshares,
                Adoxio_dateofbirth = dateOfBirth,
                Adoxio_isindividual = isIndividual
            };



            ViewModels.AdoxioLegalEntity viewmodel_adoxio_legalentity = adoxio_legalentity.ToViewModel();

            string jsonString = JsonConvert.SerializeObject(viewmodel_adoxio_legalentity);

            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // parse as JSON.
            jsonString = await response.Content.ReadAsStringAsync();
            ViewModels.AdoxioLegalEntity responseViewModel = JsonConvert.DeserializeObject<ViewModels.AdoxioLegalEntity>(jsonString);

            // name should match.
            Assert.Equal(initialName, responseViewModel.name);
            Guid id = new Guid(responseViewModel.id);

            // R - Read

            request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + id);
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            jsonString = await response.Content.ReadAsStringAsync();
            responseViewModel = JsonConvert.DeserializeObject<ViewModels.AdoxioLegalEntity>(jsonString);
            Assert.Equal(initialName, responseViewModel.name);

            // U - Update            
            adoxio_legalentity.Adoxio_name = changedName;
            adoxio_legalentity.Adoxio_legalentityid = id;
            request = new HttpRequestMessage(HttpMethod.Put, "/api/" + service + "/" + id)
            {
                Content = new StringContent(JsonConvert.SerializeObject(adoxio_legalentity.ToViewModel()), Encoding.UTF8, "application/json")
            };
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // verify that the update persisted.

            request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + id);
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            jsonString = await response.Content.ReadAsStringAsync();

            responseViewModel = JsonConvert.DeserializeObject<ViewModels.AdoxioLegalEntity>(jsonString);
            Assert.Equal(changedName, responseViewModel.name);

            // D - Delete

            request = new HttpRequestMessage(HttpMethod.Post, "/api/" + service + "/" + id + "/delete");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // second delete should return a 404.
            request = new HttpRequestMessage(HttpMethod.Post, "/api/" + service + "/" + id + "/delete");
            response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            // should get a 404 if we try a get now.
            request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + id);
            response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            await Logout();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestFileUpload()
        {
            // First create a Legal Entity

            string initialName = "InitialName";
            string changedName = "ChangedName";
            string service = "adoxiolegalentity";

            await LoginAsDefault();

            // C - Create
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/" + service);

            Adoxio_legalentity adoxio_legalentity = new Adoxio_legalentity()
            {
                Adoxio_legalentityid = Guid.NewGuid(),
                Adoxio_legalentitytype = (int?)ViewModels.Adoxio_applicanttypecodes.PrivateCorporation,
                Adoxio_position = (int?)ViewModels.PositionOptions.Director,
                Adoxio_name = initialName
            };

            ViewModels.AdoxioLegalEntity viewmodel_adoxio_legalentity = adoxio_legalentity.ToViewModel();

            string jsonString = JsonConvert.SerializeObject(viewmodel_adoxio_legalentity);

            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // parse as JSON.
            jsonString = await response.Content.ReadAsStringAsync();
            ViewModels.AdoxioLegalEntity responseViewModel = JsonConvert.DeserializeObject<ViewModels.AdoxioLegalEntity>(jsonString);

            // name should match.
            Assert.Equal(initialName, responseViewModel.name);
            string id = responseViewModel.id;

            // Attach a file

            string testData = "This is just a test.";
            byte[] bytes = Encoding.ASCII.GetBytes(testData);
            string documentType = "Test Document Type";

            // Create random filename
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[9];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var randomString = new String(stringChars);
            string filename = randomString + ".txt";

            MultipartFormDataContent multiPartContent = new MultipartFormDataContent("----TestBoundary");
            var fileContent = new MultipartContent { new ByteArrayContent(bytes) };
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
            fileContent.Headers.ContentDisposition.Name = "File";
            fileContent.Headers.ContentDisposition.FileName = filename;
            multiPartContent.Add(fileContent);
            multiPartContent.Add(new StringContent(documentType), "documentType");   // form input

            // create a new request object for the upload, as we will be using multipart form submission.
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/api/" + service + "/" + id + "/attachments");
            requestMessage.Content = multiPartContent;

            var uploadResponse = await _client.SendAsync(requestMessage);
            uploadResponse.EnsureSuccessStatusCode();

            // Verify that the file Meta Data matches

            // Verify that the file can be downloaded and the contents match            

            // Cleanup the Legal Entity

            request = new HttpRequestMessage(HttpMethod.Post, "/api/" + service + "/" + id + "/delete");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // should get a 404 if we try a get now.
            request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + id);
            response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
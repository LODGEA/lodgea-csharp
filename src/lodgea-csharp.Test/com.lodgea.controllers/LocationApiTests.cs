/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://lodgea.redoc.ly for more information.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@lodgea.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.com.lodgea.model;

namespace lodgea-csharp.Test
{
    /// <summary>
    ///  Class for testing LocationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LocationApiTests
    {
        private LocationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' LocationApi
            //Assert.IsInstanceOf(typeof(LocationApi), instance);
        }

        
        /// <summary>
        /// Test V1LocationSearchPost
        /// </summary>
        [Test]
        public void V1LocationSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationSearch locationSearch = null;
            //var response = instance.V1LocationSearchPost(locationSearch);
            //Assert.IsInstanceOf(typeof(V1LocationSearchPost200Response), response, "response is V1LocationSearchPost200Response");
        }
        
    }

}

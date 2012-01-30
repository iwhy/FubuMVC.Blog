﻿using System.IO;
using FubuMVC.Core.Runtime;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Blog
{
  public class NewtonSoftJsonWriter : IJsonWriter
  {
    private readonly IOutputWriter _outputWriter;

    public NewtonSoftJsonWriter(IOutputWriter outputWriter)
    {
      _outputWriter = outputWriter;
    }

    public void Write(object output)
    {
      Write(output, MimeType.Json.ToString());
    }

    public void Write(object output, string mimeType)
    {
      _outputWriter.Write(mimeType, ToJson(output));
    }

    private static string ToJson(object output)
    {
      var jsonSerializer = new JsonSerializer
      {
        ContractResolver = new CamelCasePropertyNamesContractResolver()
      };
      jsonSerializer.Converters.Add(new IsoDateTimeConverter());
      using (var stringWriter = new StringWriter())
      using (var jsonWriter = new JsonTextWriter(stringWriter))
      {
        jsonSerializer.Serialize(jsonWriter, output);
        return stringWriter.ToString();
      }

    }
  }
}
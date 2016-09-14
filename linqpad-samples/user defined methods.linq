<Query Kind="Program">
  <NuGetReference>Honjo</NuGetReference>
  <NuGetReference>System.Net.Http</NuGetReference>
  <Namespace>HonjoLib</Namespace>
  <Namespace>System</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <AppConfig>
    <Content>
      <configuration>
        <system.net>
          <settings>
            <httpWebRequest useUnsafeHeaderParsing="true" />
          </settings>
        </system.net>
      </configuration>
    </Content>
  </AppConfig>
  <CopyLocal>true</CopyLocal>
</Query>

public class Methods{
 public static string GetNugetApiDef() 
 { 
   string url ="http://nuget.org/api/v2/";
   var request=(HttpWebRequest)WebRequest.Create(url);
   var response = (HttpWebResponse)request.GetResponse();
   return new StreamReader(response.GetResponseStream()).ReadToEnd();
 }
}
void Main()
{
   var template="{{Math.Round(11.123)}} : {{Methods.GetNugetApiDef()}}";
   var model=new {};
   var result=new Honjo(typeof(Methods),typeof(Math)).Compile(template, model );
   result.Dump();	
}
<Query Kind="Statements">
  <NuGetReference >Honjo</NuGetReference>
  <Namespace>HonjoLib</Namespace>
</Query>

var template="{{Name}}";
var model= "{\"Name\":\"Samuel\"}";
var result=new Honjo().Compile(template, model);
result.Dump();
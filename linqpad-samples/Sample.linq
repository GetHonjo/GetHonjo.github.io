<Query Kind="Statements">
  <NuGetReference >Honjo</NuGetReference>
  <Namespace>HonjoLib</Namespace>
</Query>

var template="{{Name}}";
var model=new {Name="Samuel"};
var result=new Honjo().Compile(template, model );
result.Dump();
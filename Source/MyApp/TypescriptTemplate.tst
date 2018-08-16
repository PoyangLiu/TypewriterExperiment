// tslint:disable
// This file is auto-generated. Do not modify.
#reference "~~\MyTypewriterHelper\bin\Debug\MyTypewriterHelper.dll"
${
    using Typewriter.Extensions.Types;
    using MyTypewriterHelper;

    Template(Settings settings) { settings.IncludeCurrentProject(); }
    
    string PrintTimestamp(File f) => string.Format("// Generated on {0:yyyy-MM-dd HH:mm:ss tt}", DateTime.Now);
    bool HasExportToTypeScriptAttribute(dynamic item) => TypewriterHelper.HasExportToTypeScriptAttribute(item);
    string Debug(Class c) => TypewriterHelper.PrintDebug(c);
    string Debug(Interface i) => TypewriterHelper.PrintDebug(i);

}$PrintTimestamp
$Classes($HasExportToTypeScriptAttribute)[
// $Debug
export interface $Name$TypeParameters {
    $Properties[
    $Name: $Type;]
    $Methods[
    $Name($Parameters[$name: $Type, ]): $Type;]
}]
$Enums($HasExportToTypeScriptAttribute)[
export enum $Name {
    $Values[
    $Name = $Value,]
}]
$Interfaces($HasExportToTypeScriptAttribute)[
// $Debug
export interface $Name$TypeParameters {
    $Properties[
    $Name: $Type;]
    $Methods[
    $Name($Parameters[$name: $Type, ]): $Type;]
}]

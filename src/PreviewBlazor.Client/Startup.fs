namespace PreviewBlazor.Client

open Microsoft.AspNetCore.Blazor.Hosting
open Bolero.Remoting.Client
open System.Threading.Tasks

module Program =
    [<EntryPoint>]
    let Main args =
        let builder = WebAssemblyHostBuilder.CreateDefault(args)
        builder.RootComponents.Add<Main.MyApp>("#main")
        builder.Services.AddRemoting() |> ignore
        builder.Build().RunAsync() |> Async.AwaitTask |> Async.StartImmediate
        0
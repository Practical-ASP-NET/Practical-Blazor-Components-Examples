# Practical-Blazor-Components-Examples

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=master&repo=601686023)

## Project Structure

### Courses.Demos.Shared
Most of the components for the app can be found here.

This is the place to look for code for specific examples/exercises from [the workshop](https://practical-blazor-components.dev).

### Courses.Demos.Server
This is the project you'll want to run.

It will launch the app using Blazor Server (initially).

### Courses.Demos
This is a Blazor WASM host for the app.

When you've successfully launched the Server app you'll see a handy button (top right) to toggle between using Blazor WASM and Blazor Server.

Clicking that will run the app (via this project) using WASM, or (via the Server app) Blazor Server.

If you want to debug the app I'd probably stick with Blazor Server (debugging WASM gets complicated!)

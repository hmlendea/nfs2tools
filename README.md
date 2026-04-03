[![Donate](https://img.shields.io/badge/-%E2%99%A5%20Donate-%23ff69b4)](https://hmlendea.go.ro/fund.html) [![Latest Release](https://img.shields.io/github/v/release/hmlendea/nucicraft-api)](https://github.com/hmlendea/nucicraft-api/releases/latest) [![Build Status](https://github.com/hmlendea/nfs2tools/actions/workflows/dotnet.yml/badge.svg)](https://github.com/hmlendea/nfs2tools/actions/workflows/dotnet.yml)

# About

NFS2 Tools is a collection of converters and editors that aid in modding the game Need for Speed 2.

## Target Framework

The project currently targets `net10.0`.

## Development

### Prerequisites

- .NET SDK compatible with the target framework

### Build

```bash
dotnet build NFS2Tools.csproj
```

### Run

```bash
dotnet run --project NFS2Tools.csproj
```

### Test

There is currently no test project in this repository.

If you add one later, run:

```bash
dotnet test
```

## Contributing

Contributions are welcome.

When contributing:

- keep the project cross-platform
- preserve the existing public API unless a breaking change is intentional
- keep changes focused and consistent with the current coding style
- update the documentation when behaviour changes
- include tests for any new behaviour

## License

Licensed under the GNU General Public License v3.0 or later.
See [LICENSE](./LICENSE) for details.

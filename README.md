[![Donate](https://img.shields.io/badge/-%E2%99%A5%20Donate-%23ff69b4)](https://hmlendea.go.ro/fund.html) [![Latest Release](https://img.shields.io/github/v/release/hmlendea/nfs2tools)](https://github.com/hmlendea/nfs2tools/releases/latest) [![Build Status](https://github.com/hmlendea/nfs2tools/actions/workflows/dotnet.yml/badge.svg)](https://github.com/hmlendea/nfs2tools/actions/workflows/dotnet.yml)

# About

NFS2 Tools is a command-line utility focused on data conversion for **Need for Speed 2** modding workflows.

It currently supports conversion between game-specific binary files and XML for:

- Race statistics (`.stf` <-> `.xml`)
- Localisation files (`.eng`, `.fre`, `.ger`, `.ita`, `.spa`, `.swe` <-> `.xml`)

The tool is designed for quick, script-friendly usage: provide an input file path and an output file path, and conversion direction is inferred from file extensions.

## Target Framework

The project currently targets `net10.0`.

## Development

### Prerequisites

- .NET SDK compatible with the target framework

To verify your SDK installation:

```bash
dotnet --info
```

### Build

```bash
dotnet build NFS2Tools/NFS2Tools.csproj
```

### Run

The CLI expects exactly two arguments:

1. Input file path
2. Output file path

General form:

```bash
dotnet run --project NFS2Tools/NFS2Tools.csproj -- <input-file> <output-file>
```

Examples:

- Convert race stats to XML

```bash
dotnet run --project NFS2Tools/NFS2Tools.csproj -- records.stf records.xml
```

- Convert XML back to race stats

```bash
dotnet run --project NFS2Tools/NFS2Tools.csproj -- records.xml records.stf
```

- Convert localisation file to XML

```bash
dotnet run --project NFS2Tools/NFS2Tools.csproj -- language.eng language.xml
```

- Convert XML back to localisation format

```bash
dotnet run --project NFS2Tools/NFS2Tools.csproj -- language.xml language.eng
```

If arguments are missing or unsupported extensions are provided, the tool prints `Invalid arguments` or performs no conversion.

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

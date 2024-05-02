## My System Spec
This is a Windows application that retrieves your system specifications and writes them to both JSON and text files.

### Features
* Generates detailed system information reports.
* Saves reports in two formats: JSON and plain text.
* Easy to use and understand output files.

### Installation
There are currently no pre-built binaries available. You'll need to compile the source code yourself.

1. Clone this repository:

```Bash
git clone https://github.com/atocodes/My-System-Spec.git
```

2. Open the solution in Visual Studio and build the project.
3. Run the compiled executable (MSS.exe) located in the bin folder (Debug or Release).

### Usage
1. Run MSS.exe.
2. The application will generate system information reports and save them in the same directory as the executable.
    * SystemSpec.json: Contains the information in JSON format.
    * SystemSpec.txt: Contains the information in a human-readable text format.

### How it Works
The application retrieves information about your system using various .NET libraries and then formats it into JSON and text files.

### Contributing
You're welcome contributions to this project! Please see the CONTRIBUTING.md file for details on how to submit pull requests.

### License
This project is licensed under the MIT License. See the LICENSE file for details.
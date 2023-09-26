### 4.0.0 [July 14, 2023]
* Update to openapi-gnerator v6.6.0
* Add new API options (including prince_options[pdf_forms] to enable PDF forms)

### 3.0.0 [November 15, 2022]
* Switch API host to more secure api.docraptor.com (dropping old TLS)
* Switch from swagger v2.4.14 to openapi-generator v6.0.1 (better maintained)

### 2.0.0 [July 31, 2020]
* add support for hosted documents
* upgrade to latest swagger 2.4.14
* **BREAKING CHANGE**: renamed AsyncDocStatus to DocStatus
* **BREAKING CHANGE**: constructor argument casing

### 1.1.1 [June 7, 2017]
* Update RestSharp Dependency to 105.2.3

### 1.1.0 [November 3, 2016]
* Added support for the pipeline API parameter

### 1.0.0 [October 18, 2016]
* No significant code changes

### 0.4.0 [September 26, 2016]
* Added support for prince_options[no_parallel_downloads]

### 0.3.1 [March 18, 2016]
* Include DLL in package

### 0.3.0 [March 11, 2016]
* **BREAKING CHANGE**: Update interface for Doc initialization, see https://github.com/DocRaptor/docraptor-csharp/commit/a0d93186835efd8367d74bc8cc3b09d593a6d21f#diff-95b6812eec86fb339a01b84602935296 for how to update calls.
* Added support for prince_options[debug]

### 0.2.0 [January 29, 2016]
* **BREAKING CHANGE**: Rename ClientApi to DocApi

### 0.1.0 [January 27, 2016]
* **BREAKING CHANGE**: CreateDoc and GetAsyncDoc responses are now byte[] instead of temp files

### 0.0.1 [January 20, 2016]
* Initial release

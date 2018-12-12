# We need https
if(getRversion() < "3.3.0") setInternet2()
VERSION <- commandArgs(TRUE)

# Downloads libarrow + dependencies
if(!file.exists(sprintf("../windows/arrow-%s/include/arrow/api.h", VERSION))){
  download.file(sprintf("https://github.com/javierluraschi/rwinlib-arrow/archive/v0.12.0.zip", VERSION), "lib.zip", quiet = TRUE)
  dir.create("../windows", showWarnings = FALSE)
  unzip("lib.zip", exdir = "../windows")
  unlink("lib.zip")
}

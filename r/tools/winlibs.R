VERSION <- commandArgs(TRUE)

if (dir.exists("../arrow")) {
  dir.create("../arrow")
}

download_name <- sprintf("../arrow/apache-arrow-%s.tar.gz", VERSION)
download_url <- sprintf("http://archive.apache.org/dist/arrow/arrow-%s/apache-arrow-%s.tar.gz", VERSION, VERSION)

if(!file.exists(download_name)) {
  if(getRversion() < "3.3.0") setInternet2()
  download.file(download_url, download_name, quiet = TRUE)
}

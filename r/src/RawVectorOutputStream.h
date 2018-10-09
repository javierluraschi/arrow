// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

#include <Rcpp.h>
#include <arrow/io/interfaces.h>
#include <arrow/status.h>

class RawVectorOutputStream : public arrow::io::OutputStream {
 public:
  RawVectorOutputStream(Rcpp::RawVector& buffer)
      : extent_bytes_written_(0), buffer_(buffer) {}

  // Implement the OutputStream interface
  arrow::Status Close() override;
  arrow::Status Tell(int64_t* position) const override;
  arrow::Status Write(const void* data, int64_t nbytes) override;

 private:
  int64_t extent_bytes_written_;
  Rcpp::RawVector& buffer_;
};

/*
The test is already set up. Just look in hello.js and make the test pass. 
*/
require('chai').should();
var hello = require('../ hello');
                    
describe('Hello', function () {
  it('should return hello', function () {
    // write a test to check if hello.js returns the string 'hello'
      var result=hello.helloFunction();
      result.should.equal('Hello');
  });
});

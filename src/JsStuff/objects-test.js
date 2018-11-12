require('chai').should();
var myObjects = require('../ objects');

describe('objects', function () {
  it('should return Bob John', function () {
    
    // TODO: 
    // complete this test so it imports objects.js into:
    // var objects = 
    
    // Rewrite objects.getFullName() in objects.js to satisfy
    // this test condition
    //objects.getFullname().should.equal('Bob John');   
    myObjects.objects.getFullname().should.equal('Bob John');
  });
});

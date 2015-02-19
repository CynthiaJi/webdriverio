'use strict';

var expect = require('chai').use(require('chai-as-promised')).expect,
  webdriverio = require('webdriverjs-angular');

describe('Calculations', function () {

  var client;

  before(function (done) {
    client = webdriverio.remote(require('../../../conf/webdriver-chrome.conf.js'));  // move this line to 00_local.uispec.js and export client global?
    client.init(done);
  });

  after(function (done) {
    client.end(done);
  });

  it('should calculate Type 1 aggregate amount', function (done) {
    var baseUrl = process.env.BASE_URL || 'http://127.0.0.1:' + (global.serverPort || '4000');
    client
      .url(baseUrl + '/?client=dummyClientId')
      .click('=Business Details')
      .setValue('[ng-model="form.fields[\'ReportingParty.Remuneration.FringeBenefits.Type1Aggregate.Amount\'].value"]', '123')  // simplify selectors when element ID fix is deployed
      .setValue('[ng-model="form.fields[\'ReportingParty.Remuneration.FringeBenefits.Type1Aggregate.Amount\'].value"]', '123')
      .getValue('[ng-model="form.fields[\'ReportingParty.FringeBenefitsTax.Type1Aggregate.Amount\'].value"]')
      .pause(10000)
      .getPathHtml('#viewport',function(err,html){
        console.log(html);
      })
      .then(function (value) {
        expect(value).to.equal('255');
      })
      .end(done);
  });
});

/*
 client
 .getHTML('#test', function(err, html) {
 console.log(html);
 // outputs the following:
 // "<div id="test"><span>Lorem ipsum dolor amet</span></div>"
 })
 .getHTML('#test', false, function(err, html) {
 console.log(html);
 // outputs the following:
 // "<span>Lorem ipsum dolor amet</span>"
 });

 <div class="col-xs-4 text-right">
 <label for="input.Intermediary.ElectronicContact.Telephone.Area.Code">24 Tax agent's declaration - Tax agent phone number - Area code</label>
 </div>
 <div class="col-xs-5">

 <input id="input.Intermediary.ElectronicContact.Telephone.Area.Code" ng-model="form.fields['Intermediary.ElectronicContact.Telephone.Area.Code'].value"
  ng-change="run()" class="form-control ng-valid ng-dirty ng-valid-parse ng-touched" ng-readonly="form.fields['Intermediary.ElectronicContact.Telephone.Area.Code'].source === 'calculation'" source-selection="Intermediary.ElectronicContact.Telephone.Area.Code" type="text">


 <p class="ng-binding ng-hide" ng-show="form.fields['Intermediary.ElectronicContact.Telephone.Area.Code'].errors.length > 0"></p>

 </div>

 */

//create by cynthia

//create by cynthia
//working in progress
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg2.cjspec.js

'use strict';

//
// Set up form server and Selenium for local testing.
// Ignore this file when testing with externally deployed application and when using BrowserStack et al.
//

var Static = require('node-static'),
  http = require('http'),
  path = require('path'),
  portfinder = require('portfinder'),
  selenium = require('selenium-standalone');

var server,
  seleniumProcess;

before(function (done) {
  var file = new Static.Server(path.join(__dirname, '../../build/test'));
  server = http.createServer(function (req, res) {
    req.addListener('end', function () {
      file.serve(req, res);
    }).resume();
  }).listen(0, function (err) {
    if (err) { return done(err); }
    var port = global.serverPort = server.address().port;
    console.log('Static file server running on port %s', port);
    portfinder.getPort({
      port: 40001
    }, function (err, seleniumPort) {
      if (err) { return done(err); }
      selenium.start({
        version: '2.43.1',  // PhantomJS 1.9.8 doesn't support Selenium >= 2.44.0. Version also hardcoded in package.json postinstall script
        seleniumArgs: ['-port', seleniumPort]
      }, function (err, child) {
        if (err) { return done(err); }
        seleniumProcess = child;
        global.seleniumPort = seleniumPort;
        console.log('Selenium started on port %s', seleniumPort);
        done();
      });
    });
  });
});

after(function (done) {
  if (seleniumProcess) {
    try {
      seleniumProcess.kill();
    } catch (err) {
      console.error('Could not kill selenium process');
    }
  }
  if (server) {
    try {
      server.close(done);
    } catch (err) {
      console.error('Could not close static file server');
      done(err);
    }
  } else {
    done(new Error("Couldn't stop server as it wasn't running."));
  }
});





var url0 = 'https://test.secure.myob.com/';
var url1='http://qa5.addevcloudsites.myob.com';

var url2= url1+'/clients';
//url1+'/clients/portals';
var urltax= url1+ '/tax/fbt';
var urltax2 = url1 + '/tax/edit/?client=4cccbc62-15b1-41e3-a9ed-0d93e7d05db2&duedate=2015-06-25';

var title0 ='MYOB Account - Sign in';
var uemail ='onlinetax005@gmail.com';
var pw ='Myob1234';
var  title2 ='Practice Online';


var expect = require('chai').expect;
var assertions = require('mocha').it;
var assert = require('assert');


var webdriverio = require('webdriverio');


describe('Tax online test', function () {

  var client;
  this.timeout(99999999);

  before(function (done) {
    client = webdriverio.remote(require('../../../conf/webdriver-chrome.conf.js'));  // move this line to 00_local.uispec.js and export client global?
    client.init(done);
  });

  after(function (done) {
    client.end(done);
  });


  var baseUrl = process.env.BASE_URL || +url1;


  it('security page', function (done) {

    client
      .url(url1)
      .pause(2000)
      .getTitle().then(function (title) {
        console.log('Title was: ' + title);
        assert(title === title0);
        return this.url();
      })
      .call(done);
  })


  it('Github test',function(done) {
    client
      .url('https://github.com/')
      .getElementSize('.header-logo-wordmark', function(err, result) {
        assert(err === undefined);
        assert(result.height === 26);
        //assert(result.width  === 37);
      })
      .getTitle(function(err, title) {
        assert(err === undefined);
        assert(title === 'GitHub · Build software better, together.');
      })
      .getCssProperty('a[href="/plans"]', 'color', function(err, result){
        assert(err === undefined);
        assert(result.value === 'rgba(65,131,196,1)');
      })
      .call(done);
  });

});

//a class="global-nav-item" ng-class="{active: $state.includes('tax')}" ui-sref="tax.fbt" href="/tax/fbt">
//http://qa5.addevcloudsites.myob.com/tax/fbt
//<a href="/tax/new" ui-sref="tax.new" class="page-header-cta btn btn-success">Add New Form</a>
//<button type="submit" class="btn btn-success">Create Return</button>
//<select style="" id="client" class="form-control ng-dirty ng-valid ng-valid-required"
// ng-model="selectedClient" ng-options="client.Name for client in clients" required="">
// <option class="ng-binding" value="">Please select</option><option label="ABC Family Trust" value="0">ABC Family Trust</option>
// <option label="Mr Bruce Adams" value="1">Mr Bruce Adams</option><option label="Prof Amy Amelia Adams" value="2">Prof Amy Amelia Adams</option>
// <option label="Adelson Limited" value="3">Adelson Limited</option><option label="Adjustment Management Limited" value="4">Adjustment Management Limited</option><option label="Advanced Properties Limited" value="5">Advanced Properties Limited</option><option label="Affordable Legal" value="6">Affordable Legal</option><option label="Anston Securities" value="7">Anston Securities</option><option label="Anstow Technologies" value="8">Anstow Technologies</option><option label="Apple Orchard Holdings" value="9">Apple Orchard Holdings</option><option label="Arram Associates" value="10">Arram Associates</option><option label="Ashworth &amp; Co" value="11">Ashworth &amp; Co</option><option label="Australian Chalets" value="12">Australian Chalets</option><option label="Balthazar Marketing" value="13">Balthazar Marketing</option><option label="Berry Technicals Ltd" value="14">Berry Technicals Ltd</option><option label="Blue Metal &amp; Gravel Pty Limited" value="15">Blue Metal &amp; Gravel Pty Limited</option><option label="Mr James Bolt" value="16">Mr James Bolt</option><option label="Mr Neville Bolt" value="17">Mr Neville Bolt</option><option label="Bonnydoon Pty Ltd" value="18">Bonnydoon Pty Ltd</option><option label="Mr Richard Burdall" value="19">Mr Richard Burdall</option><option label="Ms Sophia Calabrese" value="20">Ms Sophia Calabrese</option><option label="Canvey Limited" value="21">Canvey Limited</option><option label="Mr Ray Charles" value="22">Mr Ray Charles</option><option label="Clark &amp; Co" value="23">Clark &amp; Co</option><option label="Classic Zips Limited" value="24">Classic Zips Limited</option><option label="Clear Limited" value="25">Clear Limited</option><option label="Clear Policies Ltd" value="26">Clear Policies Ltd</option><option label="Clear Water Limited" value="27">Clear Water Limited</option><option label="Clearwater Pty Ltd" value="28">Clearwater Pty Ltd</option><option label="Clement Keys Associates" value="29">Clement Keys Associates</option><option label="Coalition Movements Ltd" value="30">Coalition Movements Ltd</option><option label="Conway Movements Ltd" value="31">Conway Movements Ltd</option><option label="Correction Limited" value="32">Correction Limited</option><option label="Crewkerne Limited" value="33">Crewkerne Limited</option><option label="Curly Steel" value="34">Curly Steel</option><option label="Darnells Pty Limited" value="35">Darnells Pty Limited</option><option label="Mrs Kerry Davids" value="36">Mrs Kerry Davids</option><option label="Davis &amp; Co" value="37">Davis &amp; Co</option><option label="Mr James Dean" value="38">Mr James Dean</option><option label="Defiant Paper Limited" value="39">Defiant Paper Limited</option><option label="Deftly Limited" value="40">Deftly Limited</option><option label="Demco Family Trust" value="41">Demco Family Trust</option><option label="Demco Pty Limited" value="42">Demco Pty Limited</option><option label="Miss Suzie Linda Demco" value="43">Miss Suzie Linda Demco</option><option label="Mr Andrew Leslie Demco" value="44">Mr Andrew Leslie Demco</option><option label="Mr Peter Demco" value="45">Mr Peter Demco</option><option label="Mrs Linda Demco" value="46">Mrs Linda Demco</option><option label="Dermatic Abrasives" value="47">Dermatic Abrasives</option><option label="Derv Supplies Limited" value="48">Derv Supplies Limited</option><option label="Development Systems Limited" value="49">Development Systems Limited</option><option label="DHL Atkins &amp; Sons Pty Limited" value="50">DHL Atkins &amp; Sons Pty Limited</option><option label="Mrs Anne Dodds" value="51">Mrs Anne Dodds</option><option label="Edwins Pty Limited" value="52">Edwins Pty Limited</option><option label="Entry Order Phones Ltd" value="53">Entry Order Phones Ltd</option><option label="Established Arrivals Pty Ltd" value="54">Established Arrivals Pty Ltd</option><option label="Estate Allocations" value="55">Estate Allocations</option><option label="Estate Maintenance" value="56">Estate Maintenance</option><option label="Lady Julia Alecia Evans" value="57">Lady Julia Alecia Evans</option><option label="Sir Robert Graeme Evans" value="58">Sir Robert Graeme Evans</option><option label="Federal Employment" value="59">Federal Employment</option><option label="Mr Mitchell Feldman" value="60">Mr Mitchell Feldman</option><option label="Fieldtest Corporation" value="61">Fieldtest Corporation</option><option label="Fishers Electrical Retailers Ltd" value="62">Fishers Electrical Retailers Ltd</option><option label="Franklin Water Retention Pty Limited" value="63">Franklin Water Retention Pty Limited</option><option label="Mr Trevor Franks" value="64">Mr Trevor Franks</option><option label="Frankston Publishing Limited" value="65">Frankston Publishing Limited</option><option label="Freedom Travellers Limited" value="66">Freedom Travellers Limited</option><option label="Freemans Pty Limited" value="67">Freemans Pty Limited</option><option label="Frisco Smash Repairs" value="68">Frisco Smash Repairs</option><option label="Frome Castings Limited" value="69">Frome Castings Limited</option><option label="Futures Systems Pty Limited" value="70">Futures Systems Pty Limited</option><option label="Miss Lidia Galea" value="71">Miss Lidia Galea</option><option label="Ms Jane Gardner" value="72">Ms Jane Gardner</option><option label="Ms Sue Gardner" value="73">Ms Sue Gardner</option><option label="General Fashion Pty Limited" value="74">General Fashion Pty Limited</option><option label="Golf Pro Supplies" value="75">Golf Pro Supplies</option><option label="Grand Dowels Pty Limited" value="76">Grand Dowels Pty Limited</option><option label="Great Mills Limited" value="77">Great Mills Limited</option><option label="Greater West Trading Co Pty Limited" value="78">Greater West Trading Co Pty Limited</option><option label="Mr Phil Greene" value="79">Mr Phil Greene</option><option label="Haines &amp; Co Pty Limited" value="80">Haines &amp; Co Pty Limited</option><option label="Ms Marie Harding" value="81">Ms Marie Harding</option><option label="Mr Timothy James Harris" value="82">Mr Timothy James Harris</option><option label="Mr Peter Heeler" value="83">Mr Peter Heeler</option><option label="Hello Developments Ltd" value="84">Hello Developments Ltd</option><option label="Helsinki Tours" value="85">Helsinki Tours</option><option label="Heritage Home Units Pty Limited" value="86">Heritage Home Units Pty Limited</option><option label="HW Tankersley Pty Limited" value="87">HW Tankersley Pty Limited</option><option label="Mr Indiv Mid Individual" value="88">Mr Indiv Mid Individual</option><option label="Joe Fish &amp; Chips" value="89">Joe Fish &amp; Chips</option><option label="Mrs Annabel Johnson" value="90">Mrs Annabel Johnson</option><option label="Jones Family Trust" value="91">Jones Family Trust</option><option label="Jones Super Fund" value="92">Jones Super Fund</option><option label="Mr John Jones" value="93">Mr John Jones</option><option label="Mr Kenneth Alan Jones" value="94">Mr Kenneth Alan Jones</option><option label="Mr Paul Jones" value="95">Mr Paul Jones</option><option label="Mrs Mary Louise Jones" value="96">Mrs Mary Louise Jones</option><option label="Kilostream Limited" value="97">Kilostream Limited</option><option label="Kingston Smith Pty Limited" value="98">Kingston Smith Pty Limited</option><option label="Xaview LeChance Pty Limited" value="99">Xaview LeChance Pty Limited</option><option label="Letchworth Limited" value="100">Letchworth Limited</option><option label="Martin &amp; Co" value="101">Martin &amp; Co</option><option label="Miller and Miller" value="102">Miller and Miller</option><option label="Mitchams Pty Limited" value="103">Mitchams Pty Limited</option><option label="Mowers and Things" value="104">Mowers and Things</option><option label="MYOB Pty Ltd" value="105">MYOB Pty Ltd</option><option label="Negative Prints Pty Limited" value="106">Negative Prints Pty Limited</option><option label="Newtown Cloning Pty Limited" value="107">Newtown Cloning Pty Limited</option><option label="NL Limited" value="108">NL Limited</option><option label="Non chargeable" value="109">Non chargeable</option><option label="Overtime Carriers Pty Limited" value="110">Overtime Carriers Pty Limited</option><option label="Jesse Pantaloni" value="111">Jesse Pantaloni</option><option label="Mr John Lawrence Parker" value="112">Mr John Lawrence Parker</option><option label="My Partnership" value="113">My Partnership</option><option label="PaveTest Limited" value="114">PaveTest Limited</option><option label="Pearsons Pty Limited" value="115">Pearsons Pty Limited</option><option label="Dr Leslie Phillips" value="116">Dr Leslie Phillips</option><option label="Mr Donald Pleasance" value="117">Mr Donald Pleasance</option><option label="Professional Consulting Limited" value="118">Professional Consulting Limited</option><option label="Rankine Pty Limited" value="119">Rankine Pty Limited</option><option label="Real Time InfoSys Limited" value="120">Real Time InfoSys Limited</option><option label="Realtime Limited" value="121">Realtime Limited</option><option label="Mr Greg Richards" value="122">Mr Greg Richards</option><option label="Rowbotham Holdings" value="123">Rowbotham Holdings</option><option label="Sandhurst Medical Supplies Ltd" value="124">Sandhurst Medical Supplies Ltd</option><option label="Mr Jack Savage" value="125">Mr Jack Savage</option><option label="Mr David Sedley" value="126">Mr David Sedley</option><option label="Seven Seas Shipping Limited" value="127">Seven Seas Shipping Limited</option><option label="Signal Pyrotechnics Pty Limited" value="128">Signal Pyrotechnics Pty Limited</option><option label="Simeon &amp; Simeon" value="129">Simeon &amp; Simeon</option><option label="Simple Scaffolding Pty Limited" value="130">Simple Scaffolding Pty Limited</option><option label="Skippers Auto Repairs" value="131">Skippers Auto Repairs</option><option label="Mr Tom Small" value="132">Mr Tom Small</option><option label="Mr Fred Smith" value="133">Mr Fred Smith</option><option label="Stalybridge Trading Company Limited" value="134">Stalybridge Trading Company Limited</option><option label="Stoy &amp; Co" value="135">Stoy &amp; Co</option><option label="Terrorvision Effects Limited" value="136">Terrorvision Effects Limited</option><option label="the corner shop" value="137">the corner shop</option><option label="Mr Cedric Thest" value="138">Mr Cedric Thest</option><option label="Mrs Beatrice Thest" value="139">Mrs Beatrice Thest</option><option label="Toda Limited" value="140">Toda Limited</option><option label="Tovell Castings Ltd" value="141">Tovell Castings Ltd</option><option label="Traction Systems Limited" value="142">Traction Systems Limited</option><option label="The Training Centre Limited" value="143">The Training Centre Limited</option><option label="The Trial Bay Gaol Inc" value="144">The Trial Bay Gaol Inc</option><option label="The Trust for Beneficial Interests" value="145">The Trust for Beneficial Interests</option><option label="Tunetones Pty Ltd" value="146">Tunetones Pty Ltd</option><option label="Uptons Limited" value="147">Uptons Limited</option><option label="Value Added Pty Ltd" value="148">Value Added Pty Ltd</option><option label="Verby Limited" value="149">Verby Limited</option><option label="Victory Emblaming Pty Limited" value="150">Victory Emblaming Pty Limited</option><option label="Wadley &amp; Co Pty Limited" value="151">Wadley &amp; Co Pty Limited</option><option label="WH Smith Limited" value="152">WH Smith Limited</option><option label="Whistlestop Tours" value="153">Whistlestop Tours</option><option label="Wilson Storage" value="154">Wilson Storage</option><option label="Wilson Travel Pty Ltd" value="155">Wilson Travel Pty Ltd</option><option label="Mr Tom Wilson" value="156">Mr Tom Wilson</option><option label="Yeti Tours" value="157">Yeti Tours</option><option label="Zebedee International" value="158">Zebedee International</option><option label="Zen Pharmaceuticals Limited" value="159">Zen Pharmaceuticals Limited</option><option label="Zero Rate Limited" value="160">Zero Rate Limited</option><option label="Zoltan's (Roselands) Pty Limited" value="161">Zoltan's (Roselands) Pty Limited</option></select>
//css=i.fa.fa-bars
//css=a.pull-left

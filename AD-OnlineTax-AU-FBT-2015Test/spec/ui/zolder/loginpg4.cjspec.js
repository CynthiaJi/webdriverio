.click('=Clients', function(err, text) {
  assert(text === 'Clients'); // outputs: "WebdriverIO"
})
  .pause(2000)
  .click('=Accounting', function(err, text) {
    assert(text === 'Accounting'); // outputs: "WebdriverIO"
  })
  .pause(2000)
  .click('=Documents', function(err, text) {
    assert(text === 'Documents'); // outputs: "WebdriverIO"
  })
  .pause(2000)
  .click('=Practice manager', function(err, text) {
    assert(text === 'Practice manager'); // outputs: "WebdriverIO"
  })
  .pause(2000)
  .click('=Tasks', function(err, text) {
    assert(text === 'Tasks'); // outputs: "WebdriverIO"
  })
  .pause(2000)
  .click('=Tax', function(err, text) {
    assert(text === 'Tax'); // outputs: "WebdriverIO"
  })
  .pause(2000)
  .click('=Add New Form', function(err, text) {
    assert(text === 'Add New Form'); // outputs: "WebdriverIO"
  })

// Include some shared credentials
var config = require('./config.json');

// Include the library for the APIs
var BlueJeansMeetingsRestApi = require('../src/index');

// Instantiate the service APIs
var authSvc = new BlueJeansMeetingsRestApi.AuthenticationApi();
var historySvc = new BlueJeansMeetingsRestApi.HistoryApi();

// Authenticate with username & password grant type
authSvc.getTokenByPassword(
	{
		'grant_type': 'password',
		'username': config.username,
		'password': config.password
	},
	function (err, grant)
	{
		if (err) console.log(err);
		if (err) return;

		// Store the access token into the API client for subsequent calls
		historySvc.apiClient.authentications.access_token.apiKey = grant.access_token;

		// Go fetch info about each meeting
		historySvc.listMeetingsByUser(grant.scope.user, {}, function (err, meetings)
		{
			if (err) console.log(err);
			if (err) return;

			meetings.forEach(function (meeting)
			{
				console.log('Meeting: ' + meeting.meetingNumericId);

				meeting.participantList.forEach(function (particpant)
				{
					console.log('Particpant: ' + particpant.endpointName);
				});

				console.log('');
			});
		});
	}
);
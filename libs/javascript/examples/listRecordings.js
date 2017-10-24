// Include some shared credentials
var config = require('./config.json');

// Include the library for the APIs
var BlueJeansMeetingsRestApi = require('../src/index');

// Instantiate the service APIs
var authSvc = new BlueJeansMeetingsRestApi.AuthenticationApi();
var historySvc = new BlueJeansMeetingsRestApi.HistoryApi();
var recordingSvc = new BlueJeansMeetingsRestApi.RecordingApi();
var userSvc = new BlueJeansMeetingsRestApi.UserApi();

// Authenticate with username & password grant type
authSvc.getTokenByPassword(
	{
		'grant_type': 'password',
		'username': config.username,
		'password': config.password
	},
	function (err, grant)
	{
		// Store the access token into the API client for subsequent calls
		historySvc.apiClient.authentications.access_token.apiKey = grant.access_token;

		// Go fetch my recordings
		historySvc.listRecordings(grant.scope.user,
			{
				pageSize: 10,
				pageNumber: 1,
				sortBy: 'start_time',
				order: 'desc'
			}, function (err, recordings)
		{
			if (err) console.log(err);
			if (err) return;

			// Iterate over all your recordings
			recordings.forEach(function (recording)
			{
				// Get detailed information about each recording
				historySvc.getRecording(grant.scope.user, recording.recordingEntityId, function (err, details)
				{
					if (err) console.log(err);
					if (err) return;

					// Iterate over the chapters in the recording
					details.recordingChapters.forEach(function (chapter)
					{
						// Ask the content management system for the URL of the recording
						recordingSvc.getRecordingContent(grant.scope.user, chapter.compositeContentId, function (err, response)
						{
							if (err) console.log(err);
							if (err) return;
					
							console.log('Recording: ' + recording.recordingName);
							console.log(response.contentUrl);
							console.log('');
						});
					});
				});
			});
		});
	}
);
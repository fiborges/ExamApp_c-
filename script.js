const connection = new signalR.HubConnectionBuilder()
    .withUrl("/videohub")
    .build();

navigator.mediaDevices.getUserMedia({ video: true, audio: true })
    .then(stream => {
        const localVideo = document.getElementById("localVideo");
        localVideo.srcObject = stream;

        const videoTrack = stream.getVideoTracks()[0];
        const audioTrack = stream.getAudioTracks()[0];

        connection.start().then(() => {
            // Enviar vídeo e áudio em intervalos regulares (ajuste conforme necessário)
            setInterval(() => {
                connection.invoke("SendVideo", "user", videoTrack);
                connection.invoke("SendAudio", "user", audioTrack);
            }, 100);
        });

        connection.on("ReceiveVideo", (user, video) => {
            const remoteVideo = document.getElementById("remoteVideo");
            remoteVideo.srcObject = video;
        });

        connection.on("ReceiveAudio", (user, audio) => {
            const remoteAudio = document.getElementById("remoteVideo");
            remoteAudio.srcObject = audio;
        });
    })
    .catch(error => console.error('Error accessing media devices.', error));

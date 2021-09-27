// import nodemailer from "nodemailer";


// export default async function send(email, subject, message) {
//     const transporter = nodemailer.createTransport({
//         service: "Mailgun",
//         auth: {
//             user: settings.MAILGUN_USER,
//             pass: settings.MAILGUN_PASS
//         },
//         tls: {
//             rejectUnauthorized: false
//         }
//     })


//     var mailOptions = {
//         from: email,
//         to: 'germain.leignel@gmail.com',
//         subject: subject,
//         text: message
//     };

//     transporter.sendMail(mailOptions, function (error, info) {
//         if (error) {
//             console.log(error);
//         } else {
//             console.log('Email sent: ' + info.response);
//         }
//     });
// }




import mailgun from "mailgun-js";

export default async function send(email, subject, message) {
    const DOMAIN = "sandbox8305db292586479583f615ac8365ac50.mailgun.org";
    const mg = mailgun({ apiKey: "4f5be48ae6f21b1173890c86d932285e-dbdfb8ff-f9645e1d", domain: DOMAIN });
    const data = {
        from: email,
        to: 'germain.leignel@gmail.com',
        subject: subject,
        text: message
    };
    mg.messages().send(data, function (error, body) {
        console.log(body);
    });
}
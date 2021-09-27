/**
 * @type {import('@sveltejs/kit').RequestHandler}
 */
function validateEmail(email: string): boolean {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}

export async function post({ body }) {
    const content = JSON.parse(body);
    const subject = content.subject,
        email = content.email,
        message = content.message;

    // check if the data is empty
    if (!subject || !email || !message) {
        console.log('empty');
        return {
            status: 400,
            body: {
                text: 'Champs obligatoires manquants'
            }
        };
    }
    // check if email is valid
    else if (!validateEmail(email)) {
        console.log('invalid email');
        return {
            status: 400,
            body: {
                text: 'Email non valide'
            }
        };
    }

    return {
        status: 200,
        body: {
            text: 'Message sent, redirecting'
        },
    }
}

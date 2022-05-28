async function getAll() {
    const r = await fetch('/api/contacts');
    const d = await r.json();
    console.log(d);
}

async function post() {
    const r = await fetch('/api/contacts', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ id: 'dav', name: 'David', server: 'localhost:1234', last: 'Bye' })
       
    });
    //const d = await r.json();
    console.log(r);
}
// site.js

// Função para buscar os itens da API
async function getItems() {
    try {
        const response = await fetch('/api/todoitems'); // Rota da sua API
        if (response.ok) {
            const data = await response.json();
            console.log('Itens retornados:', data);
            // Aqui você pode manipular os dados como desejar (por exemplo, exibir na página)
        } else {
            console.error('Erro ao buscar itens:', response.status);
        }
    } catch (error) {
        console.error('Erro na requisição:', error);
    }
}

// Chama a função para buscar os itens
getItems();
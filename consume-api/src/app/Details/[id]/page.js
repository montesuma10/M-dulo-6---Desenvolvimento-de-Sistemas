import styles from './card.module.css'

export default async function Details({ params }) {
	console.log("esse e o id enviado: ", params.id)

	const card = await fetch(`http://localhost:5113/api/controller/${params.id}`).then((res) =>
		res.json(),
	)


	return (
    <div className={styles.container}>
      <div className={styles.card}>

        <img src={card.gameURL} alt={card.title} />
        <div className={styles.card_title}>
          <div className={styles.clientInfo}>
            <p>Cliente:</p><p>{card.nome}</p>
          </div>
          <div className={styles.clientInfo}>
            <p>Destino:</p><p>{card.destino}</p>
          </div>
          <div className={styles.clientInfo}>
            <p>Valor R$:</p><p>{card.valor}</p>
          </div>
          <div className={styles.clientInfo}>
            <p>CPF:</p><p>{card.cpf}</p>
          </div>
          <div className={styles.clientInfo}>
            <p>Data/ embarque:</p><p>{card.data_ida}</p>
          </div>
          <div className={styles.clientInfo}>
            <p>Data/ retorno:</p><p>{card.data_volta}</p>
          </div>
        </div>
      </div>
    </div>
  );
}

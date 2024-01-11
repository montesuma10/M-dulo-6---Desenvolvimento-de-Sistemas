import Link from 'next/link'
import styles from './card.module.css'

export default async function Card() {
	const cards = await fetch('http://localhost:5113/api/controller').then((res) =>
		res.json(),
	)
	console.log(cards)

	return (
		<div className={styles.container}>
			{cards?.map((card) => (
				<div key={card.id} className={styles.card}>
					<img src={card.gameURL} alt={card.title} />
					<div className={styles.card_title}>
						<p className={styles.clientDataLabel}>Dados do Cliente</p><p>{card.nome}</p>
					</div>
					<div className={styles.button_container}>
						<Link
							className={styles.button_link}
							href={{
								pathname: `/Details/`,
								query: { id: card.id },
							}}
							as={`/Details/${card.id}`}
							

						>
							+
						</Link>
					</div>
				</div>
			))}
		</div>
	)
}
